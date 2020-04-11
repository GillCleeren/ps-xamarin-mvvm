using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.Utility;
using BethanysPieShopStockApp.Views;
using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
    public partial class App : Application
    {
        public static NavigationService NavigationService { get; }  = new NavigationService();
        public static PieDataService PieDataServie { get; } = new PieDataService();

        public App()
        {
            InitializeComponent();

            NavigationService.Configure(ViewNames.PieOverviewView, typeof(PieOverviewView));
            NavigationService.Configure(ViewNames.PieDetailView, typeof(PieDetailView));

            MainPage = new NavigationPage(new PieOverviewView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
