using ComboBoxItemHitTestVisible.Model;
using ComboBoxItemHitTestVisible.Mvvm;
using System.Collections.Generic;
using System.Windows.Input;

namespace ComboBoxItemHitTestVisible
{
	public class MainViewModel : ObservableObject
	{
		private UserItem _currentSource;

		public ICommand CheckCommand { get; set; }

		public List<UserItem> Source { get; set; }
		public UserItem CurrentSource
		{
			get { return _currentSource; }
			set { _currentSource = value; OnPropertyChanged(); }
		}

		public MainViewModel()
		{
			CheckCommand = new RelayCommand<UserItem>(Check);

			var source = new List<UserItem>();
			source.Add(new UserItem { DisplayName = "James", IsChecked = true });
			source.Add(new UserItem { DisplayName = "Elena", IsChecked = true });
			source.Add(new UserItem { DisplayName = "Faker", IsChecked = false });
			Source = source;
		}

		private void Check(UserItem obj)
		{
			CurrentSource = obj;
		}
	}
}
