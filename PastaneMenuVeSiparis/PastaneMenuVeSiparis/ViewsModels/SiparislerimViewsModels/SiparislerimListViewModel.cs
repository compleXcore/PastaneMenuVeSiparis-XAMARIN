using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.Views.SiparislerimViews;
using PastaneMenuVeSiparis.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.SiparislerimViewsModels
{
    public class SiparislerimListViewModel : BaseViewModel
    {
        private INavigation navigation;
        private ObservableCollection<Siparis> _siparis;
        private bool _isBusy = false;

        public ObservableCollection<Siparis> Siparisler
        {
            get { return _siparis; }
            set
            {
                if (_siparis != value)
                {
                    _siparis = value;
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

        public SiparislerimListViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            RefreshCommand = new Command(OnRefresh);
            DetayCommand = new Command<Siparis>(OnDetay);

            OnRefresh();
        }

        private void OnDetay(Siparis siparis)
        {
            MessagingCenter.Unsubscribe<SiparislerimDetayViewModel>(this, "OnOk");
            MessagingCenter.Subscribe<SiparislerimDetayViewModel>(this, "OnOk", async (vm) =>
            {
                await navigation.PopModalAsync();
            });
            navigation.PushModalAsync(new SiparislerimDetayPage { BindingContext = new SiparislerimDetayViewModel(siparis) });
        }

        private async void OnRefresh()
        {
            IsBusy = true;
            var kullanici = App.Database.KullaniciManager.Kullanici;
            Siparisler = new ObservableCollection<Siparis>(await App.Database.SiparisManager.GetAllSiparisWithChildrenAsync(kullanici.Id, Models.Enums.Durumlar.TeslimEdildi));
            IsBusy = false;
        }
    }
}
