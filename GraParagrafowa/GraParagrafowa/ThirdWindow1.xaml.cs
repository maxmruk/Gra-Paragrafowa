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
            Close();
        }

        private void Action1button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
