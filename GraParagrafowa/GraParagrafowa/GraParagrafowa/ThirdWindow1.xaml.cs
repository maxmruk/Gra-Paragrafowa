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
using System.Windows.Shapes;

namespace GraParagrafowa
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ThirdWindow1 : Window
    {
        public ThirdWindow1()
        {
           InitializeComponent();
        }

        private void Action2button_Click(object sender, RoutedEventArgs e)
        {
            FourthWindow1 FourthWindow1 = new FourthWindow1();
            this.Visibility = Visibility.Hidden;
            FourthWindow1.Show(); //  Shows a window
        }

        private void Action1button_Click(object sender, RoutedEventArgs e)
        {
            FifthWindow1 FifthWindow1 = new FifthWindow1();
            this.Visibility = Visibility.Hidden;
            FifthWindow1.Show(); //  Shows a window
        }
    }
}
