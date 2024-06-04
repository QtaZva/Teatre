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
    /// Логика взаимодействия для AddRoleWindow.xaml
    /// </summary>
    public partial class AddRoleWindow : Window
    {
        ApplicationContext db;
        public AddRoleWindow()
        {
            InitializeComponent();
        }

        private void AddRole(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            Roles newRole = new Roles(name.Text, Piece.Text);
            db.Roles.Add(newRole);
            db.SaveChanges();
            MessageBox.Show("Роль успешно добавлена!");
        }
    }
}
