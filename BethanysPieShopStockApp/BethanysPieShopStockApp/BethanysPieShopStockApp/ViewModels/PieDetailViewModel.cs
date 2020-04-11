using BethanysPieShopStockApp.Models;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieDetailViewModel: BaseViewModel
    {
        private Pie _selectedPie;
        private PieRepository _pieRepository;

        public PieDetailViewModel()
        {
            _pieRepository = new PieRepository();

            SelectedPie = new Pie();

            MessagingCenter.Subscribe<PieOverviewViewModel, Pie>
                (this, "PieSelected", OnPieSelected);
        }

        private void OnPieSelected(PieOverviewViewModel vm, Pie pie)
        {
            SelectedPie = pie;
        }


        public Pie SelectedPie
        {
            get { return _selectedPie; }
            set
            {
                _selectedPie = value;
                OnPropertyChanged(nameof(SelectedPie));
            }
        }
    }
}
