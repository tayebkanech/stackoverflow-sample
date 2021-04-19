using BindingLastIndex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingLastIndex.ViewModels
{
	class MainViewModel
	{
		public UserItems Users { get; set; }

		public MainViewModel()
		{
			Users = new UserItems
			{
				new UserItem { Name = "James" },
				new UserItem { Name = "Elena" }
			};
		}
	}
}
