using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfQuizApp.Data;
using WpfQuizApp.Units;

namespace WpfQuizApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitBindData();
        }

        private void InitBindData()
        {
            var source = new List<ExampleModel>();
            source.Add(new ExampleModel { Sentence = "Hello @my friends." });

            foreach (var item in source)
            {
                var examCtrl = new ExampleControl();
                exams.Children.Add(examCtrl);

            }
        }
    }
}
