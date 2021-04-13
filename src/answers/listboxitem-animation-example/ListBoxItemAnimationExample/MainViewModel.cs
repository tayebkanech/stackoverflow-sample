using System.Collections.Generic;

namespace ListBoxItemAnimationExample
{
	internal class MainViewModel
	{
		private List<ActivityModel> _activities;

		public List<ActivityModel> Activities
		{ 
			get { return _activities; }
			set { _activities = value; }
		}

		public MainViewModel()
		{
			Activities = new List<ActivityModel>
			{
				new ActivityModel { Header = "Chapter 1 - Samba", SubItem = "Samba" },
				new ActivityModel { Header = "Chapter 2 - Songo", SubItem = "Songo" },
				new ActivityModel { Header = "Chapter 3 - Afrobeat", SubItem = "Afrobeat" }
			};
		}
	}
}