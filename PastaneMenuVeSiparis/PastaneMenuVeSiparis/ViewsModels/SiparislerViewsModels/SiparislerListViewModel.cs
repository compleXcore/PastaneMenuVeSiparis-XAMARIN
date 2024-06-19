using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.Views.SiparislerimViews;
using PastaneMenuVeSiparis.Views.SiparislerViews;
using PastaneMenuVeSiparis.ViewsModels.Base;
using PastaneMenuVeSiparis.ViewsModels.SiparislerimViewsModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.SiparislerViewsModels
{
    public class SiparislerListViewModel : BaseViewModel
    {
        private INavigation navigation;
        private ObservableCollection<Siparis> _items;
        private bool _isBusy = false;
        public ObservableCollection<Siparis> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                if (_isBusy != value)
                {
                    _isBusy = value;
                    OnPropertyChanged();
                }
            }
        }

        public Command RefreshCommand { get; set; }
        public Command DetayCommand { get; set; }
        public SiparislerListViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            RefreshCommand = new Command(OnRefresh);
            DetayCommand = new Command<Siparis>(OnDetay);

            OnRefresh();
        }

        private async void OnRefresh()
        {
            IsBusy = true;
            Items = new ObservableCollection<Siparis>(await App.Database.SiparisManager.GetAllSiparisWithChildrenAsync());
            IsBusy = false;
        }

        private void OnDetay(Siparis siparis)
        {
            MessagingCenter.Unsubscribe<SiparislerDetayViewModel>(this, "OnOk");
            MessagingCenter.Subscribe<SiparislerDetayViewModel>(this, "OnOk", async (vm) =>
            {
                await navigation.PopModalAsync();
            });
            navigation.PushModalAsync(new SiparislerDetayPage { BindingContext = new SiparislerDetayViewModel(siparis) });
        }
    }
}
