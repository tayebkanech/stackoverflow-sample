using System.Collections.Generic;

namespace ListBoxItemAnimationExample
{
	internal class MainViewModel
	{
		private List<UserModel> _users;

		public List<UserModel> Users
		{ 
			get { return _users; }
			set { _users = value; }
		}

		public MainViewModel()
		{
			Users = new List<UserModel>
			{
				new UserModel { Header = "Elena", SubItem = "Seoul" },
				new UserModel { Header = "James", SubItem = "Seoul" }
			};
		}
	}
}