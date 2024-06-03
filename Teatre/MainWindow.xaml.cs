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
using Teatre.Windows;

namespace Teatre
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ViewerClickButton(object sender, RoutedEventArgs e)
        {
            ChooseWindow chooseWindow = new ChooseWindow();
            chooseWindow.Show();
            this.Close();
        }

        private void DirectorClickButton(object sender, RoutedEventArgs e)
        {
            ChooseWindow chooseWindow = new ChooseWindow();
            chooseWindow.Show();
            this.Close();
        }

        private void RegiserClickButton(object sender, RoutedEventArgs e)
        {
            ChooseWindow chooseWindow = new ChooseWindow();
            chooseWindow.Show();
            this.Close();
        }
    }
}
