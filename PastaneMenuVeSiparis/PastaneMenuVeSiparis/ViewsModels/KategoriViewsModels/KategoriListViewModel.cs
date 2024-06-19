using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.Views.KategoriViews;
using PastaneMenuVeSiparis.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.KategoriViewsModels
{
    public class KategoriListViewModel : BaseViewModel
    {
        private INavigation navigation;
        private ObservableCollection<Kategori> _items;
        private bool _isBusy = false;
        public ObservableCollection<Kategori> Items
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

        public KategoriListViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            RefreshCommand = new Command(OnRefresh);
            InsertCommand = new Command(OnInsert);
            UpdateCommand = new Command<Kategori>(OnUpdate);
            DeleteCommand = new Command<Kategori>(OnDelete);

            OnRefresh();
        }

        private async void OnRefresh()
        {
            IsBusy = true;
            Items = new ObservableCollection<Kategori>(await App.Database.KategoriManager.GetAllAsync());
            IsBusy = false;
        }

        private void OnInsert()
        {
            MessagingCenter.Unsubscribe<KategoriViewModel, Kategori>(this, "OnOk");
            MessagingCenter.Subscribe<KategoriViewModel, Kategori>(this, "OnOk", async (vm, item) =>
            {
                await navigation.PopModalAsync();
                IsBusy = true;
                await App.Database.KategoriManager.SaveKategoriAsync(item);
                OnRefresh();
            });
            MessagingCenter.Unsubscribe<KategoriViewModel>(this, "OnCancel");
            MessagingCenter.Subscribe<KategoriViewModel>(this, "OnCancel", async (vm) =>
            {
                await navigation.PopModalAsync();
            });


            navigation.PushModalAsync(new KategoriPage { BindingContext = new KategoriViewModel() });
        }

        private void OnUpdate(Kategori hoca)
        {
            MessagingCenter.Unsubscribe<KategoriViewModel, Kategori>(this, "OnOk");
            MessagingCenter.Subscribe<KategoriViewModel, Kategori>(this, "OnOk", async (vm, item) =>
            {
                await navigation.PopModalAsync();
                IsBusy = true;
                await App.Database.KategoriManager.SaveKategoriAsync(item);
                OnRefresh();
            });
            MessagingCenter.Unsubscribe<KategoriViewModel>(this, "OnCancel");
            MessagingCenter.Subscribe<KategoriViewModel>(this, "OnCancel", async (vm) =>
            {
                await navigation.PopModalAsync();
            });
            navigation.PushModalAsync(new KategoriPage { BindingContext = new KategoriViewModel(hoca) });
        }

        public async void OnDelete(Kategori item)
        {
            bool cevap = await Application.Current.MainPage.DisplayAlert("Kategori Sil", $"{item.Ad} adlı kategoriyi silmek istiyor musunuz?", "Evet", "Hayır");
            if (cevap)
            {
                IsBusy = true;
                await App.Database.KategoriManager.DeleteAsync(item);
                OnRefresh();
            }
        }
    }
}
