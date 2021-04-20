using MultipleInheritanceItems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MultipleInheritanceItems.TemplateSelector
{
    public class CarTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ElectricTemplate { get; set; }
        public DataTemplate GasolineTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is Electric)
            {
                return ElectricTemplate;
            }
            else if (item is Gasoline)
            {
                return GasolineTemplate;
            }
            return base.SelectTemplate(item, container);
        }
    }
}
