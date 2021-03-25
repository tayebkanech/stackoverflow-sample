using CustomButtonStyle.Model;
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

namespace CustomButtonStyle
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button btn1 = new Button();
            btn1.Style = this.FindResource("BTN") as Style;
            btn1.DataContext = new ButtonModel { Nation = "South Korea", ImageUrl = "Images/korea.png"};

            Button btn2 = new Button();
            btn2.Style = this.FindResource("BTN") as Style;
            btn2.DataContext = new ButtonModel { Nation = "USA", ImageUrl = "Images/usa.png" };

            Button btn3= new Button();
            btn3.Style = this.FindResource("BTN") as Style;
            btn3.DataContext = new ButtonModel { Nation = "UK", ImageUrl = "Images/uk.png" };

            grid.Children.Add(btn1);
            grid.Children.Add(btn2);
            grid.Children.Add(btn3);
        }
    }
}
