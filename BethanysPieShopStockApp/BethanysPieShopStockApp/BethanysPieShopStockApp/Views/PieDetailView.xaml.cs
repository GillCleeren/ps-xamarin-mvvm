using BethanysPieShopStockApp.Utility;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PieDetailView : ContentPage
	{
		public PieDetailView ()
		{
			InitializeComponent ();
			
			BindingContext = ViewModelLocator.PieDetailViewModel;
		}
	}
}