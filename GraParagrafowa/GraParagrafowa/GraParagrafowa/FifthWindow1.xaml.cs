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
    public partial class FifthWindow1 : Window
    {
        public FifthWindow1()
        {
            InitializeComponent();
        }
        private void Action2button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ronan wraz z Valerianem transportują Elodie do karczmy, gdzie od razu cyrulik opatruje jej ranę. Ronan rozmyśla jak mogłoby się to wsystko potoczyć, gdyby wybrał inaczej", "Ratunek Elodie-Porażka", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }

        private void Action1button_Click(object sender, RoutedEventArgs e)
        {
            SixthWindow1 SixthWindow1 = new SixthWindow1();
            this.Visibility = Visibility.Hidden;
            SixthWindow1.Show(); //  Shows a window
        }
    }
}
