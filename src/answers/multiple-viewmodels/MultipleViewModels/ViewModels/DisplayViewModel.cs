using MultipleViewModels.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleViewModels.ViewModels
{
	public class DisplayViewModel :ObservableObject
	{
		private DateTime _time;

		public DateTime Time
		{
			get { return _time; }
			set { _time = value;OnPropertyChanged(); }
		}
	}
}
