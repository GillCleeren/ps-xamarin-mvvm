using System.Collections.ObjectModel;
using System.Windows.Input;
using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Utility;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieOverviewViewModel : BaseViewModel
    {
        private ObservableCollection<Pie> _pies;
        
        public ObservableCollection<Pie> Pies
        {
            get => _pies;
            set
            {
                _pies = value;
                OnPropertyChanged("Pies");
            }
        }

        public PieOverviewViewModel()
        {
            LoadCommand = new Command(OnLoadCommand);
            AddCommand = new Command(OnAddCommand);
            PieSelectedCommand = new Command<Pie>(OnPieSelectedCommand);

            Pies = new ObservableCollection<Pie>();

            MessagingCenter.Subscribe<PieDetailViewModel, Pie>
                (this, MessageNames.PieAddedMessage, OnPieAdded);
        }

        public ICommand LoadCommand { get; }
        public ICommand PieSelectedCommand { get; }
        public ICommand AddCommand { get; }

        private void OnLoadCommand()
        {
            Pies = PieRepository.Pies.ToObservableCollection();
        }

        private void OnPieSelectedCommand(Pie pie)
        {
            App.NavigationService.NavigateTo("PieDetailView", pie);
        }

        private void OnAddCommand()
        {
            App.NavigationService.NavigateTo("PieDetailView");
        }

        private void OnPieAdded(PieDetailViewModel sender, Pie pie)
        {
            Pies = PieRepository.Pies.ToObservableCollection();
        }
    }
}
