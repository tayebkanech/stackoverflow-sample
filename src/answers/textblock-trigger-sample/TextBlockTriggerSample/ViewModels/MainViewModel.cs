using System;
using System.Windows.Controls;
using System.Windows.Input;
using TextBlockTriggerSample.Mvvm;

namespace TextBlockTriggerSample.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		private bool _isAnimal { get; set; }
		public bool IsAnimal
		{
			get { return _isAnimal; }
			set { _isAnimal = value; OnPropertyChanged(); }
		}

		private bool _isHuman { get; set; }
		public bool IsHuman
		{
			get { return _isHuman; }
			set { _isHuman = value; OnPropertyChanged(); }
		}

		public ICommand ClickCommand { get; set; }

		public MainViewModel()
		{
			ClickCommand = new RelayCommand<CheckBox>(Click);
		}

		private void Click(CheckBox obj)
		{
			if (obj.Content.ToString() == "Human")
			{
				IsHuman = (bool)obj.IsChecked;
			}
			else if (obj.Content.ToString() == "Animal")
			{
				IsAnimal = (bool)obj.IsChecked;
			}
		}
	}
}
