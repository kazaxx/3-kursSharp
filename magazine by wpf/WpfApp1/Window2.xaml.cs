using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using static WpfApp1.Vhod;


namespace WpfApp1
{
    public partial class Window2 : Window
    {
        private unclepistonEntities1 dbContext = new unclepistonEntities1();

        public Window2()
        {
            InitializeComponent();
            DataContext = this;
            usersDataGrid.ItemsSource = dbContext.Пользователь.ToList();

        }

         private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dbContext.SaveChanges();
                ShowError("Данные успешно сохранены.");
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        private void ShowError(string errorMessage)
        {
            Error errorWindow = new Error();
            errorWindow.ShowError(errorMessage);
        }
    }

 }


