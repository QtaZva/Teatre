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
    /// Логика взаимодействия для ActorsViewWindow.xaml
    /// </summary>
    public partial class ActorsViewWindow : Window
    {
        ApplicationContext db;
        public ActorsViewWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            Actors.ItemsSource = db.Actors.ToList();
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
