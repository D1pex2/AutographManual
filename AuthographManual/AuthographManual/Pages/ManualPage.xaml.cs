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

namespace AuthographManual.Pages
{
    /// <summary>
    /// Логика взаимодействия для ManualPage.xaml
    /// </summary>
    public partial class ManualPage : Page
    {
        public ManualPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            WebBrowser.Navigate($"{Environment.CurrentDirectory}/Manuals/shortManual.html");
        }
    }
}
