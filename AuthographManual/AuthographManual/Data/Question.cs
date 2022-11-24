using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthographManual.Data
{
    public class Question
    {
        public string Text { get; }

        public Answer[] Answers { get; }

        public QuestionType Type { get; }

        public Question(string text, Answer[] answers, QuestionType type = QuestionType.Single)
        {
            Text = text;
            Answers = answers;
            Type = type;
        }
    }

    public enum QuestionType
    {
        Single,
        Multiple,
        Text
    }
}
