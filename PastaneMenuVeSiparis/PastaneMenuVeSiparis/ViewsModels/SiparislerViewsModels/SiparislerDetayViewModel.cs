using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.ViewsModels.Base;
using PastaneMenuVeSiparis.ViewsModels.SiparislerimViewsModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.SiparislerViewsModels
{
    public class SiparislerDetayViewModel : BaseViewModel
    {
        private Siparis siparis;
        private ObservableCollection<SiparisDetay> _items;
        private string _adsoyad;
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

        public string AdSoyad
        {
            get { return _adsoyad; }
            set
            {
                if(_adsoyad != value)
                {
                    _adsoyad = value;
                    OnPropertyChanged();
                }
            }
        }
        public Command OkCommand { get; set; }

        public SiparislerDetayViewModel(Siparis siparis)
        {
            this.siparis = siparis;
            _adsoyad = siparis.Kullanici.AdSoyad;
            OkCommand = new Command(OnOk);
            OnRefresh();
        }

        private async void OnRefresh()
        {
            Items = new ObservableCollection<SiparisDetay>(await App.Database.SiparisDetayManager.GetAllSiparisWithChildrenAsync(siparis.Id));
        }

        private void OnOk()
        {
            MessagingCenter.Send<SiparislerDetayViewModel>(this, "OnOk");
        }
    }
}