
using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp
{
    public partial class App : Application
    {
        public static NavigationService NavigationService { get; }
           = new NavigationService();
        public App()
        {
            InitializeComponent();

            NavigationService.Configure("PieOverview", typeof(PieOverview));
            NavigationService.Configure("PieDetailView", typeof(PieDetailView));

            MainPage = new NavigationPage(new PieOverview());
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
