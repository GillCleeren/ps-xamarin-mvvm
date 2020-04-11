using BethanysPieShopStockApp.Utility;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PieOverview : ContentPage
	{
		public PieOverview ()
		{
			InitializeComponent ();

		   //this.BindingContext = new PieOverviewViewModel();
		    this.BindingContext = ViewModelLocator.PieOverviewViewModel;
		}
	}
}