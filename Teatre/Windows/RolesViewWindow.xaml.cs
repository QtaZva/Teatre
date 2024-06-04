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
    /// Логика взаимодействия для RolesViewWindow.xaml
    /// </summary>
    public partial class RolesViewWindow : Window
    {
        ApplicationContext db;
        public RolesViewWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            Roles.ItemsSource = db.Roles.ToList();
            if (User.user == 0 || User.user == 1)
            {
                addbtn.Visibility = Visibility.Hidden;
            }
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {

        }
        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            ChooseWindow chooseWindow = new ChooseWindow();
            chooseWindow.Show();
            this.Close();
        }
    }
}
