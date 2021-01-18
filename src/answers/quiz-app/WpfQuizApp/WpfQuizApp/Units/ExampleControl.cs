using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfQuizApp.Units
{
    public class ExampleControl : Control
    {
        public static readonly DependencyProperty SentenceProperty = DependencyProperty.Register(
            "Sentence", typeof(string), typeof(ExampleControl), new PropertyMetadata(""));

        public string Header
        {
            get { return (string)this.GetValue(SentenceProperty); }
            set { this.SetValue(SentenceProperty, value); }
        }
    }
}
