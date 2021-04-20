using System.Windows.Controls;
using TextboxDatabindingSample.ViewModels;

namespace TextboxDatabindingSample.Views
{
	/// <summary>
	/// AppView.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class AppView : UserControl
	{
		public AppView()
		{
			InitializeComponent();
			DataContext = new AppViewModel();
		}
	}
}
