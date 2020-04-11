using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BethanysPieShopStockApp.Models
{
    public class Pie : INotifyPropertyChanged
    {
        private Guid _id;
        private string _pieName;
        private string _description;
        private double _price;
        private string _imageUrl;
        private bool _inStock;

        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public string PieName
        {
            get => _pieName;
            set
            {
                _pieName = value;
                RaisePropertyChanged(nameof(PieName));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }

        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                RaisePropertyChanged(nameof(ImageUrl));
            }
        }

        public bool InStock
        {
            get => _inStock;
            set
            {
                _inStock = value;
                RaisePropertyChanged(nameof(InStock));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
