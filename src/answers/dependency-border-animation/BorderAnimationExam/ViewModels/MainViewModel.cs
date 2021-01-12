using BorderAnimationExam.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BorderAnimationExam.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private bool _enable_ctl;
        public bool Enable_control
        {
            get { return _enable_ctl; }
            set { _enable_ctl = value; OnPropertyChanged(); }
        }
        

        public MainViewModel()
        {
        
        }
    }
}
