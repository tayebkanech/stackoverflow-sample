using System.Collections.ObjectModel;
using TextboxDatabindingSample.Models;
using TextboxDatabindingSample.Mvvm;

namespace TextboxDatabindingSample.ViewModels
{
	public class KundeViewModel : ObservableObject
	{
        private Kunde _skunde;
        public Kunde Skunde
        {
            get { return _skunde; }
            set { _skunde = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Kunde> _kunden;
        public ObservableCollection<Kunde> Kunden
		{
            get { return _kunden; }
			set { _kunden = value; OnPropertyChanged(); }
		}

        public KundeViewModel()
		{
            Kunden = GetKunden();
		}

		private ObservableCollection<Kunde> GetKunden()
		{
			ObservableCollection<Kunde> source = new ObservableCollection<Kunde>
			{
				new Kunde { Plz = 0 },
				new Kunde { Plz = 1 },
				new Kunde { Plz = 2 },
				new Kunde { Plz = 3 },
				new Kunde { Plz = 4 }
			};
			return source;
		}
	}
}
