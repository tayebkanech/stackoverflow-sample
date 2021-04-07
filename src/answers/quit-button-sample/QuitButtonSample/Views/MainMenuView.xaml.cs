using QuitButtonSample.ViewModels;
using System.Windows.Controls;

namespace QuitButtonSample.Views
{
    /// <summary>
    /// MainMenuView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainMenuView : UserControl
    {
        public MainMenuView()
        {
            InitializeComponent();
            DataContext = new MainMenuViewModel();
        }
    }
}
