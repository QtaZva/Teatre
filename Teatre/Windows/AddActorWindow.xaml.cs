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
    /// Логика взаимодействия для AddActorWindow.xaml
    /// </summary>
    public partial class AddActorWindow : Window
    {
        ApplicationContext db;
        public AddActorWindow()
        {
            InitializeComponent();
        }

        private void AddActor(object sender, RoutedEventArgs e) // Добавление актёра в БД 
        {
            db = new ApplicationContext();
            Actors newactor = new Actors(fullName.Text, Gender.Text, Rank.Text);
            db.Actors.Add(newactor);
            db.SaveChanges();
            MessageBox.Show("Актёр успешно добавлен!");
        }
    }
}
