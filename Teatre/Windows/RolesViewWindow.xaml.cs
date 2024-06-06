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
    public partial class RolesViewWindow : Window
    {
        ApplicationContext db;
        public RolesViewWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            Roles.ItemsSource = db.Roles.ToList();
            if (User.UserAccessLevel == 0 || User.UserAccessLevel == 1) // Скрытие кнопок для зрителей и директора
            {
                addbtn.Visibility = Visibility.Hidden;
                Roles.IsReadOnly = true;
            }
        }

        private void AddButtonClick(object sender, RoutedEventArgs e) // Создание окна добавления роли
        {
            AddRoleWindow addRoleWindow = new AddRoleWindow();
            addRoleWindow.ShowDialog();
            Roles.ItemsSource = db.Roles.ToList();
        }
        private void BackButtonClick(object sender, RoutedEventArgs e) // Кнопка возврата
        {
            ChooseWindow chooseWindow = new ChooseWindow();
            chooseWindow.Show();
            this.Close();
        }

        private void SaveChanges(object sender, SelectionChangedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
