using System;
using System.Windows;

namespace LibraryAuthentication
{
    public partial class MainWindow : Window
    {
        private string username = "admin";
        private string password = "123456";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredUsername = UsernameTextBox.Text;
            string enteredPassword = PasswordBox.Password;

            if (enteredUsername == username && enteredPassword == password)
            {
                MessageBox.Show("Авторизация успешна! Добро пожаловать, " + enteredUsername + "!");
              
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль. Попробуйте ещё раз.");
            }
        }
    }
}