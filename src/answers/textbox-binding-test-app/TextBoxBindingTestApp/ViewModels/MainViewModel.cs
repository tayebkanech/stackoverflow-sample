using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBoxBindingTestApp.Core;

namespace TextBoxBindingTestApp.ViewModels
{
	public class MainViewModel : ViewModelBase
    {
        private string creatureName;
        public string CreatureName
        {
            get
            {
                return creatureName;
            }
            set
            {
                if (!string.Equals(creatureName, value))
                {
                    creatureName = value;
                    OnPropertyChanged("CreatureName");
                }
            }
        }

        public MainViewModel()
        {
        }
    }
}
