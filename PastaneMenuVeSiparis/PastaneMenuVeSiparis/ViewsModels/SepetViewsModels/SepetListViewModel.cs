using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.SepetViewsModels
{
    public class SepetListViewModel : BaseViewModel
    {
        private INavigation navigation;
        private ObservableCollection<SiparisDetay> _items;
        private bool _isBusy = false;
        private int _toplamFiyat;
        private Siparis _siparis;

        private Kullanici Kullanici { get; set; }

        public ObservableCollection<SiparisDetay> Items
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

        public int ToplamFiyat
        {
            get { return _toplamFiyat; }
            set
            {
                if (_toplamFiyat != value)
                {
                    _toplamFiyat = value;
                    OnPropertyChanged();
                }
            }
        }

        public Command RefreshCommand { get; set; }
        public Command DeleteSiparis { get; set; }
        public Command AddSiparis { get; set; }
        public Command SiparisOnay { get; set; }

        public SepetListViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            RefreshCommand = new Command(OnRefresh);
            DeleteSiparis = new Command<SiparisDetay>(OnSiparisDeleteAsync);
            AddSiparis = new Command<SiparisDetay>(OnSiparisAddAsync);
            SiparisOnay = new Command(OnSiparisOnayAsync);

            OnRefresh();
        }

        private async void OnRefresh()
        {
            IsBusy = true;
            Kullanici = App.Database.KullaniciManager.Kullanici;
            _siparis = await App.Database.SiparisManager.GetSiparisInSepette(Kullanici.Id);
            if( _siparis != null)
            {
                ToplamFiyat = (int)_siparis.ToplamFiyat;
                Items = new ObservableCollection<SiparisDetay>(await App.Database.SiparisDetayManager.GetAllSiparisWithChildrenAsync(_siparis.Id));
            }
            else
            {
                ToplamFiyat = 0;
                Items = new ObservableCollection<SiparisDetay>();
            }
            IsBusy = false;
        }

        private async void OnSiparisDeleteAsync(SiparisDetay siparisDetay)
        {
            if(siparisDetay.Adet == 1)
            {
                _siparis.ToplamFiyat -= siparisDetay.Urun.Fiyat;
                await App.Database.SiparisDetayManager.DeleteAsync(siparisDetay);
                await App.Database.SiparisManager.SaveAsync(_siparis);
            }
            else
            {
                siparisDetay.Adet--;
                siparisDetay.Tutar -= siparisDetay.Urun.Fiyat;
                _siparis.ToplamFiyat -= siparisDetay.Urun.Fiyat;
                await App.Database.SiparisDetayManager.SaveAsync(siparisDetay);
                await App.Database.SiparisManager.SaveAsync(_siparis);
            }
            var valid = await App.Database.SiparisDetayManager.GetAllSiparisWithChildrenAsync(_siparis.Id);
            if (valid.Count == 0)
            {
                await App.Database.SiparisManager.DeleteAsync(_siparis);
            }
            OnRefresh();
        }
        private async void OnSiparisAddAsync(SiparisDetay siparisDetay)
        {
            siparisDetay.Adet++;
            siparisDetay.Tutar += siparisDetay.Urun.Fiyat;
            _siparis.ToplamFiyat += siparisDetay.Urun.Fiyat;
            await App.Database.SiparisDetayManager.SaveAsync(siparisDetay);
            await App.Database.SiparisManager.SaveAsync(_siparis);
            OnRefresh();
        }
        private async void OnSiparisOnayAsync()
        {
            if(_siparis != null)
            {
                _siparis.Durum = Models.Enums.Durumlar.TeslimEdildi;
                await App.Database.SiparisManager.SaveAsync(_siparis);
                OnRefresh();
            }
        }
    }
}