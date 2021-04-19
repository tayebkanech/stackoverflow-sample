using MultipleInheritanceItems.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceItems.ViewModels
{
	public class MainViewModel
	{
		private Car _currentCar;

		private Car CurrentCar
		{
			get { return _currentCar; }
			set { _currentCar = value; CarChanged(value); }
		}

		public List<Car> Cars { get; set; }

		public MainViewModel()
		{
			Cars = new List<Car>
			{
				new Electric { Name = "ModelS", Brand = "TESLA", BatteryCharge = 100 },
				new Gasoline { Name = "E-Class", Brand = "BENZ", Displacement = 2000 },
				new Gasoline { Name = "5-Series", Brand = "BMW", Displacement = 2000 }
			};
		}

		private void CarChanged(Car value)
		{
			if (value is Electric ele)
			{
				// Electric
				Debug.WriteLine(ele.GetType().ToString());
			}
			else if (value is Gasoline gas)
			{
				// Gasolin
				Debug.WriteLine(gas.GetType().ToString());
			}
		}
	}
}
