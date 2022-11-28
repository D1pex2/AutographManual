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
        private Test test;

        private Question currentQuestion;

        public TestPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            test = new Test("questions.xml");
            NextQuestion();
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            test.Score += Quest.CheckAnswer() ? 1 : 0;
            NextQuestion();
        }

        private void NextQuestion()
        {
            if (test.Questions.Count > 0)
            {
                currentQuestion = test.Questions.Pop();
                Quest.Initialize(currentQuestion);
                return;
            }
            MessageBox.Show($"Вы набрали {test.Score} баллов");
        }
    }
}
