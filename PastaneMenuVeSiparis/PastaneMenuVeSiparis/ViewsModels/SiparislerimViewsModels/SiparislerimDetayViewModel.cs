using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.ViewsModels.Base;
using PastaneMenuVeSiparis.ViewsModels.UrunViewsModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.SiparislerimViewsModels
{
    public class SiparislerimDetayViewModel : BaseViewModel
    {
        private Siparis siparis;
        private ObservableCollection<SiparisDetay> _items;
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

        public Command OkCommand { get; set; }

        public SiparislerimDetayViewModel(Siparis siparis)
        {
            this.siparis = siparis;
            OkCommand = new Command(OnOk);
            OnRefresh();
        }

        private async void OnRefresh()
        {
            Items = new ObservableCollection<SiparisDetay>(await App.Database.SiparisDetayManager.GetAllSiparisWithChildrenAsync(siparis.Id));
        }

        private void OnOk()
        {
            MessagingCenter.Send<SiparislerimDetayViewModel>(this, "OnOk");
        }
    }
}