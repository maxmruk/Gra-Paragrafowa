﻿using System;
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
    public partial class EighthWindow1 : Window
    {
        public EighthWindow1()
        {
            InitializeComponent();
        }
        private void Action1button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gratuluję udało ci się doprowadzic Ronana do skarbu. Bardzo dziekuję za grę!", "Zwycięstwo!", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}
