using MultipleViewModels.Core;
using MultipleViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleViewModels.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		public DisplayViewModel DisplayData { get; set; }
		public ListViewModel ListData { get; set; }

		public MainViewModel()
		{
			DisplayData = new DisplayViewModel();
			ListData = new ListViewModel();	
		}
	}
}
