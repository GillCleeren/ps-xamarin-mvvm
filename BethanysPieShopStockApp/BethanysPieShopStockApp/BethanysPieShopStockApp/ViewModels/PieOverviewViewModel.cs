using System.Collections.ObjectModel;
using System.Windows.Input;
using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Utility;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieOverviewViewModel: BaseViewModel
    {
        private ObservableCollection<Pie> _pies;
        private PieRepository _pieRepository;
        private ICommand _loadCommand;
        private ICommand _pieSelectedCommand;

        public ObservableCollection<Pie> Pies
        {
            get => _pies;
            set
            {
                _pies = value;
                OnPropertyChanged("Pies");
            }
        }

        public ICommand LoadCommand => _loadCommand ?? new Command(OnLoadCommand);
        public ICommand PieSelectedCommand => 
            _pieSelectedCommand ?? new Command<Pie>(OnPieSelectedCommand);

        private void OnPieSelectedCommand(Pie pie)
        {
            MessagingCenter.Send(this, "PieSelected", pie);
            App.NavigationService.NavigateTo("PieDetailView");
        }

        private void OnLoadCommand()
        {
            Pies = _pieRepository.Pies.ToObservableCollection();
        }

        public PieOverviewViewModel()
        {
            _pieRepository = new PieRepository();

            Pies = new ObservableCollection<Pie>();
           
        }
    }
}
