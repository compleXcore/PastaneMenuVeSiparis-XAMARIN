using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.Views.KullaniciViews;
using PastaneMenuVeSiparis.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.KullaniciViewsModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private Kullanici _model;
        private string _errorMessage = "";
        public Kullanici Model { get { return _model; } }

        public string Isim
        {
            get { return _model.Isim; }
            set
            {
                if (_model.Isim != value)
                {
                    _model.Isim = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Soyisim
        {
            get { return _model.Soyisim; }
            set
            {
                if (_model.Soyisim != value)
                {
                    _model.Soyisim = value;
                    OnPropertyChanged();
                }
            }
        }

        public string KullaniciAdi
        {
            get { return _model.KullaniciAdi; }
            set
            {
                if (_model.KullaniciAdi != value)
                {
                    _model.KullaniciAdi = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Parola
        {
            get { return _model.Parola; }
            set
            {
                if (_model.Parola != value)
                {
                    _model.Parola = value;
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

        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }

        public RegisterViewModel()
        {
            _model = new Kullanici();
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
        }

        private void OnLogin()
        {
            ErrorMessage = "";
            App.Current.MainPage = new LoginPage();
        }

        private async void OnRegister()
        {
            if (await App.Database.KullaniciManager.KullaniciCheck(_model))
            {
                if(_model.Isim == null)
                {
                    ErrorMessage = "İsim boş geçilemez";
                }
                else if(_model.Soyisim == null)
                {
                    ErrorMessage = "Soyisim Boş geçilemez";
                }
                else if(_model.KullaniciAdi == null)
                {
                    ErrorMessage = "Kullanıcı Adı boş geçilemez";
                }
                else if(_model.Parola == null)
                {
                    ErrorMessage = "Parola boş geçilemez";
                }
                else
                {
                    ErrorMessage = "";
                    await App.Database.KullaniciManager.SaveKullaniciAsync(_model);
                    App.Current.MainPage = new LoginPage();
                }
            }
            else
            {
                ErrorMessage = "Kullanıcı adı kullanılıyor başka bir kullanıcı adı seçiniz";
            }
        }
    }
}
