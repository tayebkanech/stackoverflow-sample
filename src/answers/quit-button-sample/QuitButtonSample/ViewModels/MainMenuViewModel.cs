using QuitButtonSample.Mvvm;
using System.Windows;
using System.Windows.Input;

namespace QuitButtonSample.ViewModels
{
    public class MainMenuViewModel
    {
        public ICommand QuitCommand { get; set; }

        public MainMenuViewModel()
        { 
            QuitCommand = new RelayCommand<object>(QuitApp);
        }

        private void QuitApp(object obj)
        {
            if (obj is Window window)
            {
                window.Close();
            }
        }
    }
}
