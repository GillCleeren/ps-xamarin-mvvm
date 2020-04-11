using BethanysPieShopStockApp.ViewModels;

namespace BethanysPieShopStockApp.Utility
{
    public static class ViewModelLocator
    {
        public static BethanysPieShopStockApp.ViewModels.PieOverviewViewModel PieOverviewViewModel { get; set; }
        public static PieDetailViewModel PieDetailViewModel { get; set; }

        static ViewModelLocator()
        {
            PieOverviewViewModel = new BethanysPieShopStockApp.ViewModels.PieOverviewViewModel();
            PieDetailViewModel = new PieDetailViewModel();
        }
    }
}
