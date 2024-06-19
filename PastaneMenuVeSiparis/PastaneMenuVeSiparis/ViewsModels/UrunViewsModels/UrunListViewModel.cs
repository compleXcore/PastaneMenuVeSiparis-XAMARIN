using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.Views.UrunViews;
using PastaneMenuVeSiparis.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.UrunViewsModels
{
    public class UrunListViewModel : BaseViewModel
    {
        private INavigation navigation;
        private ObservableCollection<Urun> _items;
        private bool _isBusy = false;
        public ObservableCollection<Urun> Items
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
        public Command InsertCommand { get; set; }
        public Command UpdateCommand { get; set; }
        public Command DeleteCommand { get; set; }

        public UrunListViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            RefreshCommand = new Command(OnRefresh);
            InsertCommand = new Command(OnInsert);
            UpdateCommand = new Command<Urun>(OnUpdate);
            DeleteCommand = new Command<Urun>(OnDelete);

            OnRefresh();
        }

        private async void OnRefresh()
        {
            IsBusy = true;
            Items = new ObservableCollection<Urun>(await App.Database.UrunManager.GetAllUrunWithCategoriesAsync());
            IsBusy = false;
        }

        private void OnInsert()
        {
            MessagingCenter.Unsubscribe<UrunViewModel, Urun>(this, "OnOk");
            MessagingCenter.Subscribe<UrunViewModel, Urun>(this, "OnOk", async (vm, item) =>
            {
                await navigation.PopModalAsync();
                IsBusy = true;
                await App.Database.UrunManager.SaveAsync(item);
                OnRefresh();
            });
            MessagingCenter.Unsubscribe<UrunViewModel>(this, "OnCancel");
            MessagingCenter.Subscribe<UrunViewModel>(this, "OnCancel", async (vm) =>
            {
                await navigation.PopModalAsync();
            });

            navigation.PushModalAsync(new UrunPage { BindingContext = new UrunViewModel() });
        }

        private void OnUpdate(Urun Urun)
        {
            MessagingCenter.Unsubscribe<UrunViewModel, Urun>(this, "OnOk");
            MessagingCenter.Subscribe<UrunViewModel, Urun>(this, "OnOk", async (vm, item) =>
            {
                await navigation.PopModalAsync();
                IsBusy = true;
                await App.Database.UrunManager.SaveAsync(item);
                OnRefresh();
            });
            MessagingCenter.Unsubscribe<UrunViewModel>(this, "OnCancel");
            MessagingCenter.Subscribe<UrunViewModel>(this, "OnCancel", async (vm) =>
            {
                await navigation.PopModalAsync();
            });
            navigation.PushModalAsync(new UrunPage { BindingContext = new UrunViewModel(Urun) });
        }

        public async void OnDelete(Urun Urun)
        {
            bool cevap = await App.Current.MainPage.DisplayAlert("Urun Sil", $"{Urun.Ad} adlı Uruni silmek istiyor musunuz?", "Evet", "Hayır");
            if (cevap)
            {
                IsBusy = true;
                await App.Database.UrunManager.DeleteAsync(Urun);
                OnRefresh();
            }
        }
    }
}
