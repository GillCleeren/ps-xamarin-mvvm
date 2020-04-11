using BethanysPieShopStockApp.ViewModels;

namespace BethanysPieShopStockApp.Utility
{
    public static class ViewModelLocator
    {
        public static PieOverviewViewModel PieOverviewViewModel { get; set; } = new PieOverviewViewModel(App.PieDataServie, App.NavigationService);
        public static PieDetailViewModel PieDetailViewModel { get; set; } = new PieDetailViewModel(App.PieDataServie, App.NavigationService);
    }
}
