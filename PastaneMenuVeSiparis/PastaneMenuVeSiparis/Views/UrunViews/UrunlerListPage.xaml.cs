using PastaneMenuVeSiparis.ViewsModels.UrunViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PastaneMenuVeSiparis.Views.UrunViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrunlerListPage : ContentPage
    {
        public UrunlerListPage()
        {
            InitializeComponent();

            BindingContext = new UrunlerListViewModel(Navigation);
        }
    }
}