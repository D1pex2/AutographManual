using AuthographManual.Data;
using AuthographManual.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace AuthographManual.Controls
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Quest : UserControl
    {
        private Test test;
        private Question currentQuestion;

        private List<RadioButton> radioButtons = new List<RadioButton>();
        private List<CheckBox> checkBoxes = new List<CheckBox>();

        private DispatcherTimer timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 1) };

        private int questionTime;
        public int QuestionTime
        {
            get => questionTime;
            set
            {
                TimerTextBlock.Text = $"Время на вопрос: {value} секунд";
                questionTime = value;
            }
        }

        public int Grade { get => test.Grade; }

        public event EventHandler QuestEnd;

        public Quest()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            QuestionTime--;
            if (QuestionTime <= 0)
            {
                timer.Stop();
                Answer();
            }
        }

        public void InitializeTest(Test test)
        {
            this.test = test;
            NextQuestion();
        }

        private void NextQuestion()
        {
            if (test.Questions.Count > 0)
            {
                ProgressTextBlock.Text = $"Вопрос {test.QuestionQuantity - test.Questions.Count + 1} из {test.QuestionQuantity}.";
                currentQuestion = test.Questions.Pop();
                InitializeQuestion(currentQuestion);
                return;
            }
            timer.Stop();
            QuestEnd?.Invoke(this, EventArgs.Empty);
        }

        private void InitializeQuestion(Question question)
        {
            currentQuestion = question;
            QuestionTextBlock.Text = question.Text;
            Clear();
            question.Answers.Shuffle();
            switch (question.Type)
            {
                case QuestionType.Single:
                    InitializeSingle(question);
                    break;
                case QuestionType.Multiple:
                    InitializeMultiple(question);
                    break;
                case QuestionType.Text:
                    InitializeText(question);
                    break;
                default:
                    break;
            }
            timer.Start();
        }

        private void Clear()
        {
            AnswerTextBox.Visibility = CheckAnswerLabel.Visibility = Visibility.Collapsed;
            AnswerTextBox.Clear();
            foreach (var item in radioButtons)
            {
                StackPanel.Children.Remove(item);
            }
            foreach (var item in checkBoxes)
            {
                StackPanel.Children.Remove(item);
            }
        }

        private void InitializeSingle(Question question)
        {
            QuestionTime = 30;
            foreach (var answer in question.Answers)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Content = answer.Text;
                radioButton.Tag = answer.IsRight;
                radioButton.GroupName = "Answers";
                radioButtons.Add(radioButton);
                StackPanel.Children.Add(radioButton);
            }
        }

        private void InitializeMultiple(Question question)
        {
            QuestionTime = 60;
            foreach (var answer in question.Answers)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Content = answer.Text;
                checkBox.Tag = answer.IsRight;
                checkBoxes.Add(checkBox);
                StackPanel.Children.Add(checkBox);
            }
        }

        private void InitializeText(Question question)
        {
            QuestionTime = 90;
            AnswerTextBox.Visibility = Visibility.Visible;
        }

        public void Answer()
        {
            if (CheckAnswerLabel.Visibility == Visibility.Visible)
            {
                NextQuestion();
                return;
            }
            var correct = currentQuestion.Answers.Where(a => a.IsRight).Select(a => a.Text).Aggregate((a, b) => $"{a}\n{b}");
            CheckAnswerLabel.Visibility = Visibility.Visible;
            if (CheckAnswer())
            {
                test.Score++;
                CheckAnswerLabel.Content = $"Вы ответили верно. Ваш ответ:\n{correct}";
                CheckAnswerLabel.Background = Brushes.LightGreen;
            }
            else
            {
                CheckAnswerLabel.Content = $"Вы ответили не верно. Правильный ответ:\n{correct}";
                CheckAnswerLabel.Background = Brushes.Crimson;
            }
        }

        private bool CheckAnswer()
        {
            switch(currentQuestion.Type)
            {
                case QuestionType.Single:
                    foreach (var radioButton in radioButtons)
                    {
                        if ((bool)radioButton.Tag && (bool)radioButton.IsChecked)
                        {
                            return true;
                        }
                    }
                    return false;
                case QuestionType.Multiple:
                    foreach (var checkBox in checkBoxes)
                    {
                        if (!(bool)checkBox.IsChecked && (bool)checkBox.Tag || (bool)checkBox.IsChecked && !(bool)checkBox.Tag)
                        {
                            return false;
                        }
                    }
                    return true;
                case QuestionType.Text:
                    var correctAnswer = currentQuestion.Answers.FirstOrDefault(a => a.IsRight);
                    if (correctAnswer == null)
                    {
                        return false;
                    }
                    return correctAnswer.Text.ToLower().Trim() == AnswerTextBox.Text.ToLower().Trim();
                default:
                    return false;
            }
        }
    }
}
