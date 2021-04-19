using DatagridBindingSample.ViewModels;
using System.Windows.Controls;

namespace DatagridBindingSample.Views
{
	/// <summary>
	/// MainView.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainView : UserControl
	{
		public MainView()
		{
			InitializeComponent();
			DataContext = new MainViewModel();
		}

	}
}
