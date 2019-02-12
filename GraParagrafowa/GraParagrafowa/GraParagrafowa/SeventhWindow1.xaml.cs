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
    public partial class SeventhWindow1 : Window
    {
        public SeventhWindow1()
        {
            InitializeComponent();
        }
        private void Action2button_Click(object sender, RoutedEventArgs e)
        {
            EighthWindow1 EighthWindow1 = new EighthWindow1();
            this.Visibility = Visibility.Hidden;
            EighthWindow1.Show(); //  Shows a window
        }

        private void Action1button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ronan rzuca się z pomocą Valerianowi, lecz wąż zdołał go głeboko ukąsić. Elodie próbuje aatakować węża mieczem, ale gad jest szybszy i kąsi ją w ramię. Elodie pada na ziemię obok Valeriana, a Ronan upuściwszy pochodnię stara się ugodzić mieczem kobrę. Gad jednak znowu okazuje się szybszy kąsając Ronana w brzuch. Ciała trójki poszukiwaczy przygód, służą weżowi za pożywienie na długie miesiące", "Leże Kobry-Porażka", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}
