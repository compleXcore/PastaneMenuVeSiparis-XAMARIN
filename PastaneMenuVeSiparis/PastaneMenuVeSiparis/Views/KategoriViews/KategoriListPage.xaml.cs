using PastaneMenuVeSiparis.ViewsModels.KategoriViewsModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PastaneMenuVeSiparis.Views.KategoriViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KategoriListPage : ContentPage
    {
        public KategoriListPage()
        {
            InitializeComponent();

            BindingContext = new KategoriListViewModel(Navigation);
        }
    }
}