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
    /// Логика взаимодействия для GiveRootWindow.xaml
    /// </summary>
    public partial class GiveRootWindow : Window
    {
        ApplicationContext db;
        public GiveRootWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            UsersListBox.ItemsSource = db.Users.ToList(); // Вывод пользователей в ListBox
        }

        private void SaveChanges(object sender, RoutedEventArgs e) // Сохранение изменений
        {
            db.SaveChanges();
            MessageBox.Show("Изменения сохранены!");
        }
    }
}
