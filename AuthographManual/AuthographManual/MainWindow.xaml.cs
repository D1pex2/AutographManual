using AuthographManual.Pages;
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

namespace AuthographManual
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();      
            MainFrame.Navigate(new ManualPage());
        }

        private void ManualButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ManualPage());
        }

        private void TestInterfaceButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TestPage("interface.xml", "Интерфейс"));
        }

        private void TestWork1Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TestPage("workInProgram1.xml", "Работа в программе ч. 1"));
        }

        private void TestWork2Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TestPage("workInProgram2.xml", "Работа в программе ч. 2"));
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HelpPage());
        }
    }
}
