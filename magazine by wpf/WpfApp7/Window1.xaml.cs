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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow1 = new MainWindow();
            mainwindow1.Show();
            this.Visibility = Visibility.Collapsed; // Скрыть текущую форму
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 mainwindow2 = new Window2();
            mainwindow2.Show();
            this.Visibility = Visibility.Collapsed;
        }
    }
}
