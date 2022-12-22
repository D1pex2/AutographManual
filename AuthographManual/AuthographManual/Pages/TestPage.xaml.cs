using AuthographManual.Data;
using AuthographManual.Tools;
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

namespace AuthographManual.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        private string testPath;

        public TestPage(string testPath, string testName = "")
        {
            InitializeComponent();
            this.testPath = testPath;
            if (!String.IsNullOrWhiteSpace(testName))
            {
                TestTitleTextBlock.Text = $"Для начала тестирования по теме \"{testName}\" нажмите на кнопку «Начать».";
            }
        }

        private void Quest_QuestEnd(object sender, EventArgs e)
        {
            TestStackPanel.Visibility = Visibility.Collapsed;
            ResultStackPanel.Visibility = Visibility.Visible;
            GradeTextBlock.Text = $"Ваша оценка {Quest.Grade}.";
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartTest();
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            StartTest();
        }

        private void StartTest()
        {
            try
            {
                Quest.InitializeTest(new Test(testPath, 10));
                Quest.QuestEnd += Quest_QuestEnd;
                StartStackPanel.Visibility = ResultStackPanel.Visibility = Visibility.Collapsed;
                TestStackPanel.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
