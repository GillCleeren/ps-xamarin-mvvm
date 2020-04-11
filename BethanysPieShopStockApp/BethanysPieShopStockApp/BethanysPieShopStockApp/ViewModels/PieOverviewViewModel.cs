using System.Collections.ObjectModel;
using System.Windows.Input;
using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.Utility;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieOverviewViewModel : BaseViewModel
    {
        private ObservableCollection<Pie> _pies;

        private IPieDataService _pieDataService;
        private INavigationService _navigationService;
        
        public ObservableCollection<Pie> Pies
        {
            get => _pies;
            set
            {
                _pies = value;
                OnPropertyChanged("Pies");
            }
        }

        public PieOverviewViewModel(IPieDataService pieDataService, INavigationService navigationService)
        {
            _pieDataService = pieDataService;
            _navigationService = navigationService;

            LoadCommand = new Command(OnLoadCommand);
            AddCommand = new Command(OnAddCommand);
            PieSelectedCommand = new Command<Pie>(OnPieSelectedCommand);

            Pies = new ObservableCollection<Pie>();

            MessagingCenter.Subscribe<PieDetailViewModel, Pie>
                (this, MessageNames.PieChangedMessage, OnPieChanged);
        }

        public ICommand LoadCommand { get; }
        public ICommand PieSelectedCommand { get; }
        public ICommand AddCommand { get; }

        public void OnLoadCommand()
        {
            //Pies = new ObservableCollection<Pie>(PieRepository.Pies);
            //Pies = new ObservableCollection<Pie>(App.PieDataServie.GetAllPies());
            Pies = new ObservableCollection<Pie>(_pieDataService.GetAllPies());
        }

        private void OnPieSelectedCommand(Pie pie)
        {
            //App.NavigationService.NavigateTo("PieDetailView", pie);
            _navigationService.NavigateTo("PieDetailView", pie);
        }

        private void OnAddCommand()
        {
            //App.NavigationService.NavigateTo("PieDetailView");
            _navigationService.NavigateTo("PieDetailView");
        }

        private void OnPieChanged(PieDetailViewModel sender, Pie pie)
        {
            //Pies = new ObservableCollection<Pie>(PieRepository.Pies);
            //Pies = new ObservableCollection<Pie>(App.PieDataServie.GetAllPies());
            Pies = new ObservableCollection<Pie>(_pieDataService.GetAllPies());
        }
    }
}
