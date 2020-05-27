﻿
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientBase
{
    public partial class ClientsWindow : Window
    {
        public ClientsWindow()
        {
            InitializeComponent();
        }

        private void ClientCardButton_Click(Object sender, RoutedEventArgs args)
        {
            Button button = sender as Button;
            switch (button.Content)
            {
                case "+": button.Content = "-"; break;
                case "-": button.Content = "+"; break;
            }
        }

        private void ClientsCollectionViewSource_Filter(Object sender, FilterEventArgs args)
        {
            args.Accepted = false;
        }
    }
}
