using PastaneMenuVeSiparis.Models;
using System;
using Xamarin.Forms;

namespace PastaneMenuVeSiparis
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();

            menuPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItemModel;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);

            Detail = new NavigationPage(page);
            IsPresented = false;

            menuPage.ListView.SelectedItem = null;
        }
    }
}
