using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ComboBoxItemHitTestVisible.Mvvm
{
    public class ObservableObject : INotifyPropertyChanged
    {
        protected bool IsFirstTimeViewLoaded { get; set; }
        protected bool IsFirstTimeLoaded { get; set; }
        public bool IsInitializedComponent { get; private set; }

        protected FrameworkElement View { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void ForceLoaded(FrameworkElement view)
        {
            View = view;
            InitializedComponont();

            if (!IsFirstTimeLoaded)
            {
                OnLoaded();
            }
        }

        public void ForceViewLoaded(FrameworkElement view)
        {
            View = view;
            InitializedComponont();

            if (!IsFirstTimeViewLoaded)
            {
                OnViewLoaded();
            }
        }

        private void InitializedComponont()
        {
            if (!IsInitializedComponent)
            {
                IsInitializedComponent = true;
                OnInitializedComponent();
            }
        }

        protected virtual void OnLoaded()
        {

        }

        protected virtual void OnViewLoaded()
        {

        }

        protected virtual void OnInitializedComponent()
        {

        }
    }
}