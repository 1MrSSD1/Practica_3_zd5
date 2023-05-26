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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr3_005
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(xBox.Text);
            double y = double.Parse(yBox.Text);
            if (x >= 0 && x <= 70 && y >= 0 && y <= 70)
            {
                txtOtv.Text = "Да";
            }
            else if (x == 0 || y == 0 || x == 70 || y == 70)
            {
                txtOtv.Text = "На границе";
            }
            else
            {
                txtOtv.Text = "Нет";
            }
        }
    }
}
