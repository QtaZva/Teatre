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
using Teatre.Classes;
using Teatre.Windows;

namespace Teatre
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginClickButton(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            var UserLog = db.Users.Where(u => u.Login == LoginTextBox.Text && u.Password == PasswordTextBox.Password).FirstOrDefault();
            if(UserLog != null)
            {
                MessageBox.Show("Вы успешно вошли!");
                User.UserAccessLevel = UserLog.AccessLevel;
                CreateChooseWindow();
            }
            else
            {
                MessageBox.Show("Логин или пароль были введены неправильно!");
                LoginTextBox.Clear();
                PasswordTextBox.Clear();
            }
        }
        private void CreateChooseWindow()
        {
            ChooseWindow chooseWindow = new ChooseWindow();
            chooseWindow.Show();
            this.Close();
        }

        private void RegisterClickButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
