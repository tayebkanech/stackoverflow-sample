using TextboxDatabindingSample.Mvvm;
using TextboxDatabindingSample.Views;

namespace TextboxDatabindingSample.ViewModels
{
    public class AppViewModel : ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        private KundeViewModel _kundeVM;
        public KundeViewModel KundeVM
        {
            get { return _kundeVM; }
            set { _kundeVM = value; OnPropertyChanged(); }
        }

        public AppViewModel()
        {
            KundeVM = new KundeViewModel();
            CurrentView = KundeVM;

            SubView win = new SubView();
            win.DataContext = this;
            win.Show();
        }
    }
}
