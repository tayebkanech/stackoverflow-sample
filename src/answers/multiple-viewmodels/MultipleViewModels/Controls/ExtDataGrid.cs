using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MultipleViewModels.Controls
{
	public class ExtDataGrid : DataGrid
    {
        public static readonly DependencyProperty DoubleClickCommandProperty = DependencyProperty.Register("DoubleClickCommand", typeof(ICommand), typeof(ExtDataGrid), new UIPropertyMetadata());

        public ICommand DoubleClickCommand
        {
            get { return (ICommand)GetValue(DoubleClickCommandProperty); }
            set { SetValue(DoubleClickCommandProperty, value); }
        }

        public ExtDataGrid()
        {
			PreviewMouseDoubleClick += ExtDataGrid_PreviewMouseDoubleClick;
        }

		private void ExtDataGrid_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
            DoubleClickCommand?.Execute(e.OriginalSource);
		}
	}
}
