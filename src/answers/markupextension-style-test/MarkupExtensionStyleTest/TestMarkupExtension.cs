using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace MarkupExtensionStyleTest
{
public class TestMarkup : MarkupExtension
{
    public string Extension { get; set; }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        var target = (IProvideValueTarget)serviceProvider.GetService(typeof(IProvideValueTarget));
        if (target.TargetObject is Button ctl)
        {

        }
        return Extension;
    }
}
}
