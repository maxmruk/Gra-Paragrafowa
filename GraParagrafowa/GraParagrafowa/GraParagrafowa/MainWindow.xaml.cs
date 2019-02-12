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

namespace GraParagrafowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Action2button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dziękuje za Grę. Pozdrawiam Maksymilian Mruk", "Podziękowanie", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }

        private void Action1button_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow1 SecondWindow1 = new SecondWindow1();
            this.Visibility = Visibility.Hidden;
            SecondWindow1.Show(); //  Shows a window
        }
    }
}
