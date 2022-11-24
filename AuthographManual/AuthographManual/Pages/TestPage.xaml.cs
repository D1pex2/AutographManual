using AuthographManual.Data;
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
        public TestPage()
        {
            InitializeComponent();
            Question question1 = new Question("Выберите А", new Answer[] { new Answer("A", true), new Answer("B"), new Answer("C"), new Answer("D")});
            Question question2 = new Question("Выберите А и B", new Answer[] { new Answer("A", true), new Answer("B",true), new Answer("C"), new Answer("D")}, QuestionType.Multiple);
            Question question3 = new Question("Выберите А", new Answer[] {new Answer("А", true)}, QuestionType.Text);
            test1.Initialize(question1);
            test2.Initialize(question2);
            test3.Initialize(question3);
        }

        private void CheckAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(test1.CheckAnswer().ToString());
            MessageBox.Show(test2.CheckAnswer().ToString());
            MessageBox.Show(test3.CheckAnswer().ToString());
        }
    }
}
