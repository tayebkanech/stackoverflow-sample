using QuitButtonSample.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuitButtonSample.ViewModels
{
    public class MainMenuViewModel
    {
        #region .ICommand.
        public ICommand QuitCommand { get; set; }
        #endregion

        #region .Constructor.
        public MainMenuViewModel()
        { 
            QuitCommand = new RelayCommand<object>(QuitApp);
        }

        #endregion

        #region .Method.
        private void QuitApp(object obj)
        {
            if (obj is Window window)
            {
                window.Close();
            }
        }
        #endregion
    }
}
