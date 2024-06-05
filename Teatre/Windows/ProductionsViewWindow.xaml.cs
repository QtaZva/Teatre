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
    /// Логика взаимодействия для ProductionsViewWindow.xaml
    /// </summary>
    public partial class ProductionsViewWindow : Window
    {
        ApplicationContext db;
        public ProductionsViewWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            Productions.ItemsSource = db.Productions.ToList();
            if (User.user == 0 || User.user == 1)
            {
                addbtn.Visibility = Visibility.Hidden;
                Productions.IsReadOnly = true;
            }
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            AddProductionsWindow addProductionsWindow = new AddProductionsWindow();
            addProductionsWindow.ShowDialog();
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
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
