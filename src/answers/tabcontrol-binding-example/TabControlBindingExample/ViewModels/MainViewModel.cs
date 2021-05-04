using System.Windows.Controls;
using System.Windows.Input;
using TabControlBindingExample.Mvvm;

namespace TabControlBindingExample.ViewModels
{
	public class MainViewModel
	{
		private TabsWindow win;

		public ICommand BtnClick { get; set; }

		public MainViewModel()
		{
			BtnClick = new RelayCommand<object>(Click);
		}

		private void Click(object obj)
		{
			if (obj is Button btn)
			{
				if (win is null || !win.IsVisible)
				{ 
					win = new TabsWindow();
					win.Show();
				}
				win.SetTab(btn.Content.ToString());
			}
		}
	}
}
