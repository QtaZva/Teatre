﻿using System;
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

namespace Teatre.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChooseWindow.xaml
    /// </summary>
    public partial class ChooseWindow : Window
    {
        public ChooseWindow()
        {
            InitializeComponent();
        }

        private void ActorButtonClick(object sender, RoutedEventArgs e)
        {
            ActorsViewWindow actorsViewWindow = new ActorsViewWindow();
            actorsViewWindow.Show();
            this.Close();
        }

        private void RoleButtonClick(object sender, RoutedEventArgs e)
        {
            RolesViewWindow rolesViewWindow = new RolesViewWindow();
            rolesViewWindow.Show();
            this.Close();
        }

        private void ProductionButtonClick(object sender, RoutedEventArgs e)
        {
            ProductionsViewWindow productionsViewWindow = new ProductionsViewWindow();
            productionsViewWindow.Show();
            this.Close();
        }
    }
}
