using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Utility;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieDetailViewModel: BaseViewModel
    {
        private Pie _selectedPie;
        
        public PieDetailViewModel()
        {
            SelectedPie = new Pie();
            SaveCommand = new Command(OnSaveCommand);
            MessagingCenter.Subscribe<PieOverviewViewModel, Pie>
                (this, MessageNames.PieSelectedMessage, OnPieSelected);
        }

        public ICommand SaveCommand { get; }

        private void OnSaveCommand()
        {
            PieRepository.AddPie(SelectedPie);
            MessagingCenter.Send(this, MessageNames.PieAddedMessage, SelectedPie);
            App.NavigationService.GoBack();
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
