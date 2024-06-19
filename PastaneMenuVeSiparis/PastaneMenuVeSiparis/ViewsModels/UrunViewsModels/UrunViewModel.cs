using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.UrunViewsModels
{
    public class UrunViewModel : BaseViewModel
    {
        private Urun model;
        public Urun Model { get { return model; } }

        private ObservableCollection<Kategori> _kategoriler = new ObservableCollection<Kategori>();

        public int Id
        {
            get { return model.Id; }
            set
            {
                if (model.Id != value)
                {
                    model.Id = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Ad
        {
            get { return model.Ad; }
            set
            {
                if (model.Ad != value)
                {
                    model.Ad = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Fiyat
        {
            get { return model.Fiyat; }
            set
            {
                if (model.Fiyat != value)
                {
                    model.Fiyat = value;
                    OnPropertyChanged();
                }
            }
        }

        public int KategoriId
        {
            get
            {
                return model.KategoriId;
            }
            set
            {
                if (model.KategoriId != value)
                {
                    model.KategoriId = value;
                    OnPropertyChanged();
                }
            }
        }

        public Kategori Kategori
        {
            get { return model.Kategori; }
            set
            {
                if (model.Kategori != value)
                {
                    model.Kategori = value;
                    model.KategoriId = model.Kategori.Id;
                    OnPropertyChanged();
                }
            }
        }
        public ObservableCollection<Kategori> Kategoriler
        {
            get { return _kategoriler; }
            set
            {
                if (_kategoriler != value)
                {
                    _kategoriler = value;
                    OnPropertyChanged();
                }
            }
        }

        public Command OkCommand { get; set; }
        public Command CancelCommand { get; set; }

        public UrunViewModel() : this(new Urun()) { }

        public UrunViewModel(Urun item)
        {
            //önce modeli almak sonra Initialize metoduna gitmek lazım...
            model = item;
            Initialize();

            OkCommand = new Command(OnOk);
            CancelCommand = new Command(OnCancel);

        }

        private async void Initialize()
        {
            Kategoriler = new ObservableCollection<Kategori>(await App.Database.KategoriManager.GetAllAsync());
            Kategori = _kategoriler.FirstOrDefault(x => x.Id == model.KategoriId);
        }

        private void OnOk()
        {
            MessagingCenter.Send<UrunViewModel, Urun>(this, "OnOk", model);
        }

        private void OnCancel()
        {
            MessagingCenter.Send<UrunViewModel>(this, "OnCancel");
        }
    }
}
