using System;
using System.Linq;
using System.Windows;

namespace WpfApp1
{
    public partial class Registr : Window
    {
        private Error errorForm; // Объявляем переменную для формы Error

        public Registr()
        {
            InitializeComponent();
            errorForm = new Error(); // Инициализируем форму Error
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                ShowError("Заполните все поля!");
                return;
            }

            if (password != confirmPassword)
            {
                ShowError("Пароль и подтверждение пароля не совпадают!");
                return;
            }

            using (var context = new unclepistonEntities2())
            {
                var existingUser = context.Пользователь.FirstOrDefault(u => u.Логин_пользователя == login);
                if (existingUser != null)
                {
                    ShowError("Пользователь с таким логином уже существует!");
                    return;
                }

                var newUser = new Пользователь
                {
                    Логин_пользователя = login,
                    Пароль_пользователя = password
                };

                context.Пользователь.Add(newUser);
                context.SaveChanges();
            }

            MessageBox.Show("Пользователь успешно зарегистрирован!");
            ClearFields();
            LoginTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();
        }

        private void ShowError(string errorMessage)
        {
            errorForm.ShowError(errorMessage);
        }

        private void ClearFields()
        {
            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Vhod vhod = new Vhod();
            vhod.Show();
            this.Visibility = Visibility.Collapsed;
        }
    }
}
