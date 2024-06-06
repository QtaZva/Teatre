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
    /// Логика взаимодействия для AddProductionsWindow.xaml
    /// </summary>
    public partial class AddProductionsWindow : Window
    {
        ApplicationContext db;
        public AddProductionsWindow()
        {
            InitializeComponent();
        }

        private void AddProductions(object sender, RoutedEventArgs e) // Добавление новой постановки
        {
            db = new ApplicationContext();
            Productions newProduction = new Productions(Convert.ToInt32(roleId.Text), Convert.ToInt32(actorId.Text), appointmentDate.Text, withdrawalDate.Text);
            db.Productions.Add(newProduction);
            db.SaveChanges();
        }
    }
}
