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

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            OpenWindow objSecondWindow = new SecondWindow();
            this.Visibility = Visibility.Hidden;
            objGraParagrafowa._2.show
        }

        private void Open(object sender, RoutedEventArgs e)
        {

        }
    }
}
