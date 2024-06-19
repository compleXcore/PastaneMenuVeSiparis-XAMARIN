using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis.ViewsModels.KategoriViewsModels
{
    public class KategoriViewModel : BaseViewModel
    {
        private Kategori model;
        public Kategori Model { get { return model; } }

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

        public Command OkCommand { get; set; }
        public Command CancelCommand { get; set; }

        public KategoriViewModel() : this(new Kategori()) { }

        public KategoriViewModel(Kategori item)
        {
            model = item;
            OkCommand = new Command(OnOk);
            CancelCommand = new Command(OnCancel);
        }

        private void OnOk()
        {
            MessagingCenter.Send(this, "OnOk", model);
        }

        private void OnCancel()
        {
            MessagingCenter.Send(this, "OnCancel");
        }
    }
}
