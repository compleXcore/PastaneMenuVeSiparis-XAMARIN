using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.Views.KullaniciViews;
using PastaneMenuVeSiparis.ViewsModels.Base;
using PastaneMenuVeSiparis.ViewsModels.KullaniciViewsModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.KullaniciViewsModels
{
    public class KullaniciListViewModel : BaseViewModel
    {
        private INavigation navigation;
        private ObservableCollection<Kullanici> _items;
        private bool _isBusy = false;
        public ObservableCollection<Kullanici> Items
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

        public KullaniciListViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            RefreshCommand = new Command(OnRefresh);
            InsertCommand = new Command(OnInsert);
            UpdateCommand = new Command<Kullanici>(OnUpdate);
            DeleteCommand = new Command<Kullanici>(OnDelete);

            OnRefresh();
        }

        private async void OnRefresh()
        {
            IsBusy = true;
            Items = new ObservableCollection<Kullanici>(await App.Database.KullaniciManager.GetAllAsync());
            IsBusy = false;
        }

        private void OnInsert()
        {
            MessagingCenter.Unsubscribe<KullaniciViewModel, Kullanici>(this, "OnOk");
            MessagingCenter.Subscribe<KullaniciViewModel, Kullanici>(this, "OnOk", async (vm, item) =>
            {
                await navigation.PopModalAsync();
                IsBusy = true;
                await App.Database.KullaniciManager.SaveKullaniciAsync(item);
                OnRefresh();
            });
            MessagingCenter.Unsubscribe<KullaniciViewModel>(this, "OnCancel");
            MessagingCenter.Subscribe<KullaniciViewModel>(this, "OnCancel", async (vm) =>
            {
                await navigation.PopModalAsync();
            });


            navigation.PushModalAsync(new KullaniciPage { BindingContext = new KullaniciViewModel() });
        }

        private void OnUpdate(Kullanici hoca)
        {
            MessagingCenter.Unsubscribe<KullaniciViewModel, Kullanici>(this, "OnOk");
            MessagingCenter.Subscribe<KullaniciViewModel, Kullanici>(this, "OnOk", async (vm, item) =>
            {
                await navigation.PopModalAsync();
                IsBusy = true;
                await App.Database.KullaniciManager.SaveKullaniciAsync(item);
                OnRefresh();
            });
            MessagingCenter.Unsubscribe<KullaniciViewModel>(this, "OnCancel");
            MessagingCenter.Subscribe<KullaniciViewModel>(this, "OnCancel", async (vm) =>
            {
                await navigation.PopModalAsync();
            });
            navigation.PushModalAsync(new KullaniciPage { BindingContext = new KullaniciViewModel(hoca) });
        }

        public async void OnDelete(Kullanici item)
        {
            var user = App.Database.KullaniciManager.Kullanici;
            bool cevap = await Application.Current.MainPage.DisplayAlert("Kullanici Sil", $"{item.AdSoyad} adlı Kullaniciyi silmek istiyor musunuz?", "Evet", "Hayır");
            if (cevap && user.Id != item.Id)
            {
                IsBusy = true;
                await App.Database.KullaniciManager.DeleteAsync(item);
                OnRefresh();
            }
            else if(cevap && user.Id == item.Id)
            {
                await App.Database.KullaniciManager.DeleteAsync(item);
                App.Current.MainPage = new LoginPage();
            }
        }
    }
}
