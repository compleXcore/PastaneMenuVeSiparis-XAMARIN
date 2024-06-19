using PastaneMenuVeSiparis.ViewsModels.KullaniciViewsModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PastaneMenuVeSiparis.Views.KullaniciViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KullaniciListPage : ContentPage
    {
        public KullaniciListPage()
        {
            InitializeComponent();
            BindingContext = new KullaniciListViewModel(Navigation);
        }
    }
}