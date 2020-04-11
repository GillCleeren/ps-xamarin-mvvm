using BethanysPieShopStockApp.ViewModels;

namespace BethanysPieShopStockApp.Utility
{
    public static class ViewModelLocator
    {
        public static PieOverviewViewModel PieOverviewViewModel { get; set; } = new PieOverviewViewModel();
        public static PieDetailViewModel PieDetailViewModel { get; set; } = new PieDetailViewModel();
    }
}
