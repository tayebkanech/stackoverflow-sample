using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RelativeSourceTestApp.ViewModels
{
	public class FirstViewModel
	{
		public SolidColorBrush TabControlBackground { get; set; }

		public FirstViewModel()
		{
			TabControlBackground = Brushes.Gray;
		}
	}
}
