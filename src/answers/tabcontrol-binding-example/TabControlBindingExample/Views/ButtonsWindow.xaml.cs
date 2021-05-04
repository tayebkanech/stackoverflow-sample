using System.Windows;
using TabControlBindingExample.ViewModels;

namespace TabControlBindingExample.Views
{
	/// <summary>
	/// ButtonsWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class ButtonsWindow : Window
	{
		public ButtonsWindow()
		{
			InitializeComponent();
			DataContext = new MainViewModel();
		}
	}
}
