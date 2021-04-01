using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using ListBoxBindingSample.Model;
using ListBoxBindingSample.Mvvm;

namespace ListBoxBindingSample.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        #region .Command.
        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        #endregion

        #region .Items.
        private List<RetailItems> _items;
        public List<RetailItems> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged(); }
        }

        private RetailItems _currentItem;
        public RetailItems CurrentItem
        {
            get { return _currentItem; }
            set { _currentItem = value; OnPropertyChanged(); _currentItem.Quantity = 1; }
        }
        #endregion

        #region .CartItems.
        private ObservableCollection<RetailItems> _cartItems;
        public ObservableCollection<RetailItems> CartItems
        {
            get { return _cartItems; }
            set { _cartItems = value; OnPropertyChanged(); }
        }

        private RetailItems _currentCartItem;
        public RetailItems CurrentCartItem
        {
            get { return _currentCartItem; }
            set { _currentCartItem = value; OnPropertyChanged(); }
        }
        #endregion

        #region .Cost.
        private double _taxes;
        public double Taxes
        {
            get { return _taxes; }
            set { _taxes = value; OnPropertyChanged(); }
        }

        private double _totalCost;
        public double TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; OnPropertyChanged(); }
        }
        #endregion

        #region .Constructor.
        public MainViewModel()
        {
            Items = GetRetailItems();
            CartItems = new ObservableCollection<RetailItems>();
            AddCommand = new RelayCommand<object>(AddCartItem);
            RemoveCommand = new RelayCommand<object>(RemoveCartItem);
        }

        #endregion

        private List<RetailItems> GetRetailItems()
        {
            var source = new List<RetailItems>
            {
                new RetailItems { Name = "Water", Price = 1.5, Quantity = 1 },
                new RetailItems { Name = "Milk", Price =  2.0, Quantity = 1 },
                new RetailItems { Name = "Orange", Price = 3.2, Quantity = 1 },
                new RetailItems { Name = "Cherry", Price = 5.5, Quantity = 1 },
                new RetailItems { Name = "Beer", Price = 2.0, Quantity = 1 },
            };
            return source;
        }

        private void AddCartItem(object obj)
        {
            if (obj is RetailItems r)
            {
                CartItems.Add(new RetailItems { Name = r.Name, Price = r.Price, Quantity = r.Quantity });
            }

            Taxes = CartItems.Select(i=> i.Price * i.Quantity * 0.01).Sum();
            TotalCost = CartItems.Select(i => i.Price * i.Quantity).Sum();
        }

        private void RemoveCartItem(object obj)
        {
            if (obj is RetailItems)
            {
                CartItems.Remove(CurrentCartItem);
            }

            Taxes = CartItems.Select(i => i.Price * i.Quantity * 0.01).Sum();
            TotalCost = CartItems.Select(i => i.Price * i.Quantity).Sum();
        }
    }
}
