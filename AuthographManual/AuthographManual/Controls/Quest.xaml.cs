﻿using AuthographManual.Data;
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

namespace AuthographManual.Controls
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Quest : UserControl
    {
        private Question question;

        private List<RadioButton> radioButtons = new List<RadioButton>();
        private List<CheckBox> checkBoxes = new List<CheckBox>();

        public Quest()
        {
            InitializeComponent();
        }

        public void Initialize(Question question)
        {
            this.question = question;
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
        }

        private void Clear()
        {
            AnswerTextBox.Visibility = Visibility.Collapsed;
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
            AnswerTextBox.Visibility = Visibility.Visible;
        }

        public bool CheckAnswer()
        {
            switch(question.Type)
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
                    return question.Answers.First(a => a.IsRight).Text.ToLower().Trim() == AnswerTextBox.Text.ToLower().Trim();
                default:
                    return false;
            }
        }
    }
}