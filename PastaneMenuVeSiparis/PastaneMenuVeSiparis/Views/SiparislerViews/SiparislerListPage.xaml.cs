using PastaneMenuVeSiparis.ViewsModels.SiparislerViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PastaneMenuVeSiparis.Views.SiparislerViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SiparislerListPage : ContentPage
	{
		public SiparislerListPage ()
		{
			InitializeComponent ();

            BindingContext = new SiparislerListViewModel(Navigation);
        }
	}
}