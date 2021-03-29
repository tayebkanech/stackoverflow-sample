using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace OnApplyTemplateExample
{
    public class MyTextBox : TextBox
    {
        public MyTextBox()
        { 
        
        }

        public override void OnApplyTemplate()
        {
            var border = this.Template.FindName("border", this) as Border;
            border.Background = Brushes.Red;
        }
    }
}
