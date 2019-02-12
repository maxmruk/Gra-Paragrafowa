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
    public partial class FourthWindow1 : Window
    {
        public FourthWindow1()
        {
            InitializeComponent();
        }
        private void Action2button_Click(object sender, RoutedEventArgs e)
        {
            SeventhWindow1 SeventhWindow1 = new SeventhWindow1();
            this.Visibility = Visibility.Hidden;
            SeventhWindow1.Show(); //  Shows a window
        }

        private void Action1button_Click(object sender, RoutedEventArgs e)
        {
            SixthWindow1 SixthWindow1 = new SixthWindow1();
            this.Visibility = Visibility.Hidden;
            SixthWindow1.Show(); //  Shows a window
        }
    }
}
