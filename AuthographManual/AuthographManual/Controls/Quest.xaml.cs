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

        private bool AnswerSelected
        {
            get => radioButtons.Any(r => r.IsChecked == true) || checkBoxes.Any(c => c.IsChecked == true) || !String.IsNullOrWhiteSpace(AnswerTextBox.Text);
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
            Clear();
            NextQuestion();
        }

        private void NextQuestion()
        {
            if (test.Questions.Count > 0)
            {
                AnswerButton.Content = "Ответить";
                ProgressTextBlock.Text = $"Вопрос {test.QuestionQuantity - test.Questions.Count + 1} из {test.QuestionQuantity}.";
                currentQuestion = test.Questions.Pop();
                InitializeQuestion(currentQuestion);
                return;
            }
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
            foreach (var item in radioButtons)
            {
                AnswerStackPanel.Children.Remove(item);
            }
            foreach (var item in checkBoxes)
            {
                AnswerStackPanel.Children.Remove(item);
            }
            AnswerTextBox.Visibility = CheckAnswerLabel.Visibility = EmptyAnswerLabel.Visibility = AnswerStackPanel.Visibility = Visibility.Collapsed;
            AnswerTextBox.Clear();
            radioButtons.Clear();
            checkBoxes.Clear();
        }

        private void InitializeSingle(Question question)
        {
            QuestionTime = 30;
            AnswerStackPanel.Visibility = Visibility.Visible;
            foreach (var answer in question.Answers)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Content = answer.Text;
                radioButton.Tag = answer.IsRight;
                radioButton.GroupName = "Answers";
                radioButtons.Add(radioButton);
                AnswerStackPanel.Children.Add(radioButton);
            }
        }

        private void InitializeMultiple(Question question)
        {
            QuestionTime = 60;
            AnswerStackPanel.Visibility = Visibility.Visible;
            foreach (var answer in question.Answers)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Content = answer.Text;
                checkBox.Tag = answer.IsRight;
                checkBoxes.Add(checkBox);
                AnswerStackPanel.Children.Add(checkBox);
            }
        }

        private void InitializeText(Question question)
        {
            QuestionTime = 90;
            AnswerTextBox.Visibility = Visibility.Visible;
        }

        public void Answer()
        {
            timer.Stop();
            AnswerButton.Content = "Далее";
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
                    var correctAnswers = currentQuestion.Answers.Where(a => a.IsRight);
                    if (correctAnswers == null || correctAnswers.Count() == 0)
                    {
                        return false;
                    }
                    foreach (var answer in correctAnswers)
                    {
                        if (answer.Text.ToLower().Trim() == AnswerTextBox.Text.ToLower().Trim())
                        {
                            return true;
                        }
                    }
                    return false;
                default:
                    return false;
            }
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!AnswerSelected && questionTime > 0)
            {
                EmptyAnswerLabel.Visibility = Visibility.Visible;
                return;
            }
            Answer();
        }
    }
}
