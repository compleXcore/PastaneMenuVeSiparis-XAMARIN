using PastaneMenuVeSiparis.ViewsModels.SiparislerimViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PastaneMenuVeSiparis.Views.SiparislerimViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SiparislerimListPage : ContentPage
	{
		public SiparislerimListPage ()
		{
			InitializeComponent ();

			BindingContext = new SiparislerimListViewModel(Navigation);
		}
	}
}