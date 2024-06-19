using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.Views;
using PastaneMenuVeSiparis.Views.KategoriViews;
using PastaneMenuVeSiparis.Views.KullaniciViews;
using PastaneMenuVeSiparis.Views.SepetViews;
using PastaneMenuVeSiparis.Views.SiparislerimViews;
using PastaneMenuVeSiparis.Views.SiparislerViews;
using PastaneMenuVeSiparis.Views.UrunViews;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PastaneMenuVeSiparis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutMenuPage : ContentPage
    {
        public ListView ListView;
        public Kullanici Kullanici { get; set; }

        public FlyoutMenuPage()
        {
            InitializeComponent();

            Kullanici = new Kullanici();
            Kullanici = App.Database.KullaniciManager.Kullanici;

            BindingContext = Kullanici;

            if(Kullanici.Yetki == Models.Enums.Yetkiler.Yonetici)
            {
                MenuItemsListView.ItemsSource = new ObservableCollection<MenuItemModel>(new[]
                {
                    new MenuItemModel { Id = 0, Title = "Ürün Listesi", TargetType = typeof(UrunListPage) },
                    new MenuItemModel { Id = 1, Title = "Kategori Listesi", TargetType = typeof(KategoriListPage) },
                    new MenuItemModel { Id = 2, Title = "Yönetici Listesi", TargetType = typeof(KullaniciListPage) },
                    new MenuItemModel { Id = 3, Title = "Bütün Siparişler", TargetType = typeof(SiparislerListPage) },
                    new MenuItemModel { Id = 4, Title = "Çıkış Yap", TargetType = typeof(Logout) }
                });
            }
            else
            {
                MenuItemsListView.ItemsSource = new ObservableCollection<MenuItemModel>(new[]
                {
                    new MenuItemModel { Id = 0, Title = "Anasayfa", TargetType = typeof(Anasayfa) },
                    new MenuItemModel { Id = 1, Title = "Ürünler", TargetType = typeof(UrunlerListPage) },
                    new MenuItemModel { Id = 2, Title = "Sepetim", TargetType = typeof(SepetListPage) },
                    new MenuItemModel { Id = 3, Title = "Siparişlerim", TargetType = typeof(SiparislerimListPage) },
                    new MenuItemModel { Id = 4, Title = "Çıkış Yap", TargetType = typeof(Logout) }
                });
            }

            ListView = MenuItemsListView;
        }
    }
}