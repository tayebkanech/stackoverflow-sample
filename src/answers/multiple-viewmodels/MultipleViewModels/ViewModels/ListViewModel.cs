using MultipleViewModels.Core;
using MultipleViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MultipleViewModels.ViewModels
{
	public class ListViewModel : ObservableObject
	{
		public ICommand DoubleClickCommand { get; set; }
		public List<UserItem> Users { get; }

		public ListViewModel()
		{
			DoubleClickCommand = new RelayCommand<FrameworkElement>(DoubleClick);

			Users = new List<UserItem>
			{
				new UserItem { Name = "James" },
				new UserItem { Name = "Elena" }
			};
		}

		private void DoubleClick(FrameworkElement source)
		{
			if (source.DataContext is UserItem item)
			{
				TabControl tabControl = ElementHelper.FindParent<TabControl>(source);
				TabItem tabItem1 = (TabItem)tabControl.Items[0];
				TabItem tabItem2 = (TabItem)tabControl.Items[1];

				DisplayViewModel DisplayData = (DisplayViewModel)tabItem2.DataContext;

				DisplayData.Time = DateTime.Now;
			}
		}
	}
}
