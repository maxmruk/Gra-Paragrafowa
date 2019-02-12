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
    public partial class SixthWindow1 : Window
    {
        public SixthWindow1()
        {
            InitializeComponent();
        }
        private void Action1button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ronan oraz Valerian płyną z coraz bardziej wartkim nurtem. Gdy dostrzegają przed sobą ogromny wir, jest już za późno i zostają przez niego wciągnięci. Ich szkielety do dziś dnia spoczywają na dnie rzeki.", "Rwący Strumień-Porażka", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }

        private void Action2button_Click(object sender, RoutedEventArgs e)
        {
            EighthWindow1 EighthWindow1 = new EighthWindow1();
            this.Visibility = Visibility.Hidden;
            EighthWindow1.Show(); //  Shows a window
        }
    }
}
