using System;
using System.Linq;
using System.Windows;

namespace WpfApp1
{
    public partial class Vhod : Window
    {
        public class UserRole
        {
            public const string Admin = "admin";
        }

        public class User
        {
            public string Login { get; set; }
            public string Role { get; set; }
        }
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
                User user = Proverka(login, password);
                if (user != null)
                {
                    if (user.Role == UserRole.Admin)
                    {
                        Window2 adminForm = new Window2();
                        adminForm.Show();
                    }
                    else
                    {
                        Window1 window = new Window1();
                        window.Show();
                    }

                    txtlogin.Clear();
                    txtpassword.Clear();
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
        public User Proverka(string login, string password)
        {
            try
            {
                using (var context = new unclepistonEntities2())
                {
                    var пользователь = context.Пользователь.FirstOrDefault(u => u.Логин_пользователя == login && u.Пароль_пользователя == password);
                    if (пользователь != null)
                    {
                        // Преобразование bool? в string
                        string role = пользователь.Админ.HasValue && пользователь.Админ.Value ? UserRole.Admin : "other_role";

                        return new User { Login = login, Role = role };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при обращении к базе данных: " + ex.Message);
                return null;
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


        private void ShowError(string errorMessage)
        {
            Error errorWindow = new Error();
            errorWindow.ShowError(errorMessage);
        }
    }
}
