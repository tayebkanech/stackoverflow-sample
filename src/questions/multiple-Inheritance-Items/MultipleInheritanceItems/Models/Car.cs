using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceItems.Models
{
	public class Car
	{
		public string Name { get; set; }
		public string Brand { get; set; }
		public Type Type => GetType();
	}
}
