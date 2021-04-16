using RelativeSourceTestApp.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativeSourceTestApp.ViewModels
{
	public class SecondViewModel
	{
		public ObservableCollection<UserItem> Users { get; set; }
		public SecondViewModel()
		{
			Users = new ObservableCollection<UserItem>
			{
				new UserItem { Name = "James", Info = "Seoul" },
				new UserItem { Name = "Elena", Info = "Seoul" }
			};
		}
	}
}
