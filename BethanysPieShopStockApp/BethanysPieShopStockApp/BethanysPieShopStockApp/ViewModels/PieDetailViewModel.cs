﻿using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.Utility;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieDetailViewModel : BaseViewModel
    {
        private Pie _selectedPie;

        private IPieDataService _pieDataService;
        private INavigationService _navigationService;

        public PieDetailViewModel(IPieDataService pieDataService, INavigationService navigationService)
        {
            _pieDataService = pieDataService;
            _navigationService = navigationService;

            SelectedPie = new Pie();
            SaveCommand = new Command(OnSaveCommand);
        }

        public ICommand SaveCommand { get; }

        private void OnSaveCommand()
        {
            //if (SelectedPie.Id == Guid.Empty)
            //    PieRepository.AddPie(SelectedPie);
            //else
            //    PieRepository.SavePie(SelectedPie);

            //if (SelectedPie.Id == Guid.Empty)
            //    App.PieDataServie.AddPie(SelectedPie);
            //else
            //    App.PieDataServie.UpdatePie(SelectedPie);

            if (SelectedPie.Id == Guid.Empty)
                _pieDataService.AddPie(SelectedPie);
            else
                _pieDataService.UpdatePie(SelectedPie);

            MessagingCenter.Send(this, MessageNames.PieChangedMessage, SelectedPie);
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
