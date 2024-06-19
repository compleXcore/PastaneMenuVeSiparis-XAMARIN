using PastaneMenuVeSiparis.ViewsModels.KullaniciViewsModels;
using PastaneMenuVeSiparis.ViewsModels.SepetViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PastaneMenuVeSiparis.Views.SepetViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SepetListPage : ContentPage
	{
		public SepetListPage ()
		{
			InitializeComponent();
            BindingContext = new SepetListViewModel(Navigation);
        }
	}
}