using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.Views.KullaniciViews;
using PastaneMenuVeSiparis.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.KullaniciViewsModels
{
    public class LoginViewModel : BaseViewModel
    {
        private Kullanici _model;
        private string _errorMessage = "";
        public Kullanici Model { get { return _model; } }


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

        public LoginViewModel()
        {
            _model = new Kullanici();
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnLogin()
        {
            if (await App.Database.KullaniciManager.Login(_model))
            {
                ErrorMessage = "";
                App.Current.MainPage = new MainPage();
            }
            else
            {
                ErrorMessage = "Kullanıcı adı ya da parola hatalı!!!";
            }
        }

        private void OnRegister()
        {
            ErrorMessage = "";
            App.Current.MainPage = new RegisterPage();
        }
    }
}
