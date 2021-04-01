using System;
using ListBoxBindingSample.Mvvm;

namespace ListBoxBindingSample.Model
{
    public class RetailItems : ObservableObject
    {
        private int _quantity;

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged(); }
        }
        
    }
}
