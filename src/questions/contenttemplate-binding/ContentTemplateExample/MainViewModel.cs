using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTemplateExample
{
	public class Test
	{ 
		public string Name { get; set; }
	}
	public class MainViewModel
	{
		public string Name { get; set; } = "Test;";

		public List<Test> Source = new List<Test>();
		public MainViewModel()
		{
			Source.Add(new Test());
			Source.Add(new Test());
		}
	}
}







