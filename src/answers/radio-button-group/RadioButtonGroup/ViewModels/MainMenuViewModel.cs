using RadioButtonGroup.Models;
using RadioButtonGroup.Mvvm;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace RadioButtonGroup.ViewModels
{
    public class MainMenuViewModel : ObservableObject
    {
        private List<RadioItem> _radios;
        public List<RadioItem> Radios
        {
            get { return _radios; }
            set { _radios = value; OnPropertyChanged(); }
        }

        private RadioItem _currentRadio;
        public RadioItem CurrentRadio
        {
            get { return _currentRadio; }
            set { _currentRadio = value; OnPropertyChanged(); }
        }

        public ICommand ClickCommand { get; set; }

        public MainMenuViewModel()
        {
            ClickCommand = new RelayCommand<Window>(Click);

            Radios = new List<RadioItem>
            {
                new RadioItem { DisplayName = "Radio 1" },
                new RadioItem { DisplayName = "Radio 2" },
                new RadioItem { DisplayName = "Radio 3" },
                new RadioItem { DisplayName = "Radio 4" }
            };
        }

        private void Click(Window obj)
        {
            if (CurrentRadio.DisplayName == "Radio 1")
            {
                obj.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Select another one!");
            }
        }
    }
}
