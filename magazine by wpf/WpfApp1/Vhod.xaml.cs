using System;
using System.Linq;
using System.Windows;

namespace WpfApp1
{
    public partial class Vhod : Window
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = txtlogin.Text.Trim();
            string password = txtpassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                ShowError("Пожалуйста, введите логин и пароль.");
                return;
            }

            try
            {
                if (Proverka(login, password))
                {
                    ShowError("Успешная авторизация!");
                }
                else
                {
                    ShowError("Неверный логин или пароль!");
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка авторизации: " + ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Registr registr = new Registr();
            registr.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Visibility = Visibility.Collapsed;
        }

        public bool Proverka(string login, string password)
        {
            try
            {
                using (var context = new unclepistonEntities())
                {
                    var пользователь = context.Пользователь.FirstOrDefault(u => u.Логин_пользователя == login && u.Пароль_пользователя == password);
                    return пользователь != null;
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при обращении к базе данных: " + ex.Message);
                return false;
            }
        }

        private void ShowError(string errorMessage)
        {
            Error errorWindow = new Error();
            errorWindow.ShowError(errorMessage);
        }
    }
}
