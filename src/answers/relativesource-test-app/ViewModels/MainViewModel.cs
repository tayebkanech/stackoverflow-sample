using RelativeSourceTestApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RelativeSourceTestApp.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		public FirstViewModel G1VM { get; set; }
		public SecondViewModel G2VM { get; set; }

		public SolidColorBrush GridBackground { get; set; }

		public MainViewModel()
		{
			G1VM = new FirstViewModel();
			G2VM = new SecondViewModel();

			GridBackground = Brushes.AliceBlue;
		}
	}
}
