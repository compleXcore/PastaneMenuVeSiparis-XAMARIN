using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.KullaniciViewsModels
{
    public class KullaniciViewModel : BaseViewModel
    {
        private Kullanici model;
        private string _errorMessage = "";
        public Kullanici Model { get { return model; } }

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

        public string KullaniciAdi
        {
            get { return model.KullaniciAdi; }
            set
            {
                if (model.KullaniciAdi != value)
                {
                    model.KullaniciAdi = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Parola
        {
            get { return model.Parola; }
            set
            {
                if (model.Parola != value)
                {
                    model.Parola = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Isim
        {
            get { return model.Isim; }
            set
            {
                if (model.Isim != value)
                {
                    model.Isim = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Soyisim
        {
            get { return model.Soyisim; }
            set
            {
                if (model.Soyisim != value)
                {
                    model.Soyisim = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                if (_errorMessage != value)
                {
                    _errorMessage = value;
                    OnPropertyChanged();
                }
            }
        }

        public Command OkCommand { get; set; }
        public Command CancelCommand { get; set; }

        public KullaniciViewModel() : this(new Kullanici()) { }

        public KullaniciViewModel(Kullanici item)
        {
            model = item;
            OkCommand = new Command(OnOk);
            CancelCommand = new Command(OnCancel);
        }

        private async void OnOk()
        {
            var user = App.Database.KullaniciManager.Kullanici;
            if (user.Id != model.Id)
            {
                if (await App.Database.KullaniciManager.KullaniciCheck(model))
                {
                    if (model.Isim == null) ErrorMessage = "Lütfen ismi boş bırakmayınız";
                    else if (model.Soyisim == null) ErrorMessage = "Lütfen Soyismi boş bırakmayınız";
                    else if (model.KullaniciAdi == null) ErrorMessage = "Lütfen kullanıcı adını boş bırakmayınız";
                    else if (model.KullaniciAdi != null && model.KullaniciAdi.Length < 3) ErrorMessage = "Lütfen kullanıcı adını 3 karakterden uzun yapınız";
                    else if (model.Parola == null) ErrorMessage = "Lütfen parolayı boş bırakmayınız";
                    else if (model.Parola != null && model.Parola.Length < 3) ErrorMessage = "Lütfen parolayı 3 karakterden uzun yapınız";
                    else
                    {
                        ErrorMessage = "";
                        model.Yetki = Models.Enums.Yetkiler.Yonetici;
                        MessagingCenter.Send(this, "OnOk", model);
                    }
                }
                else
                {
                    ErrorMessage = "Kullanıcı adı kullanılıyor başka bir kullanıcı adı seçiniz";
                }
            }
            else
            {
                if (model.Isim == null) ErrorMessage = "Lütfen ismi boş bırakmayınız";
                else if (model.Soyisim == null) ErrorMessage = "Lütfen Soyismi boş bırakmayınız";
                else if (model.KullaniciAdi == null) ErrorMessage = "Lütfen kullanıcı adını boş bırakmayınız";
                else if (model.KullaniciAdi != null && model.KullaniciAdi.Length < 3) ErrorMessage = "Lütfen kullanıcı adını 3 karakterden uzun yapınız";
                else if (model.Parola == null) ErrorMessage = "Lütfen parolayı boş bırakmayınız";
                else if (model.Parola != null && model.Parola.Length < 3) ErrorMessage = "Lütfen parolayı 3 karakterden uzun yapınız";
                else
                {
                    ErrorMessage = "";
                    model.Yetki = Models.Enums.Yetkiler.Yonetici;
                    MessagingCenter.Send(this, "OnOk", model);
                }
            }
        }

        private void OnCancel()
        {
            MessagingCenter.Send(this, "OnCancel");
        }
    }
}
