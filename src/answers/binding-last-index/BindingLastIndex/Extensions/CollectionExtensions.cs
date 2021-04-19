using BindingLastIndex.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BindingLastIndex
{
	public class UserItems : ObservableCollection<UserItem>, INotifyPropertyChanged
	{
		private UserItem _firstItem;
		private UserItem _userItem;

		public UserItem FirstUser
		{
			get { return _firstItem; }
			set { _firstItem = value; OnPropertyChanged(); }
		}

		public UserItem LastUser
		{
			get { return _userItem; }
			set { _userItem = value; OnPropertyChanged(); }
		}

		protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
			base.OnCollectionChanged(e);
			FirstUser = this.FirstOrDefault();
			LastUser = this.LastOrDefault();
		}

		public new event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
