using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.Views.UrunViews;
using PastaneMenuVeSiparis.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.UrunViewsModels
{
    public class UrunlerListViewModel : BaseViewModel
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
        public Command SepeteEkle { get; set; }

        public UrunlerListViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            RefreshCommand = new Command(OnRefresh);
            SepeteEkle = new Command<Urun>(OnSepeteEkleAsync);

            OnRefresh();
        }

        private async void OnRefresh()
        {
            IsBusy = true;
            Items = new ObservableCollection<Urun>(await App.Database.UrunManager.GetAllUrunWithCategoriesAsync());
            IsBusy = false;
        }

        private async void OnSepeteEkleAsync(Urun urun)
        {
            var user = App.Database.KullaniciManager.Kullanici;

            var siparis = new Siparis();
            siparis = await App.Database.SiparisManager.GetSiparisInSepette(user.Id);

            if(siparis != null)
            {
                var siparisDetay = await App.Database.SiparisDetayManager.GetAllSiparisWithChildrenAsync(siparis.Id);
                SiparisDetay siparisDetay1 = siparisDetay.FirstOrDefault(x => x.Urun.Id == urun.Id);
                if(siparisDetay1 == null)
                {
                    await App.Database.SiparisDetayManager.SaveAsync(new SiparisDetay
                    {
                        UrunId = urun.Id,
                        Adet = 1,
                        Tutar = urun.Fiyat,
                        SiparisId = siparis.Id
                    });
                    siparis.ToplamFiyat += urun.Fiyat;
                    await App.Database.SiparisManager.SaveAsync(siparis);
                }
                else
                {
                    siparisDetay1.Adet++;
                    siparisDetay1.Tutar += urun.Fiyat;
                    siparis.ToplamFiyat += urun.Fiyat;
                    await App.Database.SiparisDetayManager.SaveAsync(siparisDetay1);
                    await App.Database.SiparisManager.SaveAsync(siparis);
                }
            }
            else
            {
                siparis = new Siparis
                {
                    KullaniciId = user.Id,
                    ToplamFiyat = urun.Fiyat,
                    Tarih = DateTime.Now,
                    Durum = Models.Enums.Durumlar.Sepette
                };
                await App.Database.SiparisManager.SaveAsync(siparis);
                await App.Database.SiparisDetayManager.SaveAsync(new SiparisDetay
                {
                    UrunId = urun.Id,
                    Adet = 1,
                    Tutar = urun.Fiyat,
                    SiparisId = siparis.Id
                });
            }
        }
    }
}