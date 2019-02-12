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
    /// Interaction logic for SecondWindow1.xaml
    /// </summary>
    public partial class SecondWindow1 : Window
    {
        public SecondWindow1()
        {
            InitializeComponent();
        }

        private void Action2button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wino kobiety i śpiew są znacznie lepsze niż nadstawianie karku w jaskiniach. Ronan postaniawia się upić, by nie myśleć o utraconej szansie na odkrycie skarbów", "Karczma Gęś i Hart", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }

        private void Action1button_Click(object sender, RoutedEventArgs e)
        {
            ThirdWindow1 ThirdWindow1 = new ThirdWindow1();
            this.Visibility = Visibility.Hidden;
            ThirdWindow1.Show(); //  Shows a window
        }
    }
}
