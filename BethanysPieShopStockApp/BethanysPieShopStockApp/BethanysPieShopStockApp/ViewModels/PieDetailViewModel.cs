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
        }

        public ICommand SaveCommand { get; }

        private void OnSaveCommand()
        {
            if (SelectedPie.Id == 0)
                PieRepository.AddPie(SelectedPie);
            else
                PieRepository.SavePie(SelectedPie);

            MessagingCenter.Send(this, MessageNames.PieAddedMessage, SelectedPie);
            App.NavigationService.GoBack();
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

        public override void Initialize(object parameter)
        {
            if (parameter == null)
                SelectedPie = new Pie();
            else
                SelectedPie = parameter as Pie;
        }
    }
}
