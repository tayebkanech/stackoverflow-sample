using TextboxDatabindingSample.Mvvm;

namespace TextboxDatabindingSample.Models
{
	public class Kunde : ObservableObject
	{
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        private int _kunnr;
        public int Kunnr
        {
            get { return _kunnr; }
            set { _kunnr = value; OnPropertyChanged(); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private string _branche;
        public string Branche
        {
            get { return _branche; }
            set { _branche = value; OnPropertyChanged(); }
        }

        private string _strasse;
        public string Strasse
        {
            get { return _strasse; }
            set { _strasse = value; OnPropertyChanged(); }
        }

        private int _plz;
        public int Plz
        {
            get { return _plz; }
            set { _plz = value; OnPropertyChanged(); }
        }

        private string _ort;
        public string Ort
        {
            get { return _ort; }
            set { _ort = value; OnPropertyChanged(); }
        }
    }
}
