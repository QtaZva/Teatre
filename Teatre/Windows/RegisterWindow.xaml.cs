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
using System.Windows.Shapes;
using Teatre.Classes;

namespace Teatre.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        ApplicationContext db;
        public RegisterWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void RegistrationClickButton(object sender, RoutedEventArgs e)
        {
            if(LoginTextBox.Text.Length < 5) // Проверка на длину логина
            {
                MessageBox.Show("Данный логин слишком короткий!");
                LoginTextBox.Clear();
                PasswordTextBox.Clear();
                return;
            }
            if (db.Users.Where(u => u.Login == LoginTextBox.Text) == null) // Проверка на наличии такого логина в БД и валидация пароля
            {
                if (ValidatePassword(PasswordTextBox.Password))
                {
                    Users newUser = new Users(LoginTextBox.Text, PasswordTextBox.Password, 0);
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    MessageBox.Show("Вы успешно зарегестрировались!");
                }
            }
            else
                MessageBox.Show("Такой пользователь уже существует!");
            
        }

        private void LoginClickButton(object sender, RoutedEventArgs e) // Создание окна входа
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        public static bool ValidatePassword(string password) //Валидация пароля
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Пароль слишком маленький!");
                return false;
            }

            if (!password.Any(Char.IsLower))
            {
                MessageBox.Show("Пароль должен содержать буквы нижнего регистра!");
                return false;
            }

            if (!password.Any(Char.IsUpper))
            {
                MessageBox.Show("Пароль должен содержать буквы верхнего регистра!");
                return false;
            }

            if (!password.Any(Char.IsDigit))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну цифру!");
                return false;
            }

            if (password.Intersect("#$%^&_").Count() == 0)
            {
                MessageBox.Show("Пароль должен содержать уникальный символ(#$%^&_)");
                return false;
            }

            return true;
        }
    }
}
