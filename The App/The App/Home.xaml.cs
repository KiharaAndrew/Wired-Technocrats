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

namespace The_App
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void details_page(object sender, RoutedEventArgs e)
        {
            stdntdtls.Content = new Student_Details();
        }

        private void win3(object sender, RoutedEventArgs e)
        {
            MainWindow win3 = new MainWindow();
            win3.Show();
        }
    }
}
