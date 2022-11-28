using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthographManual.Data
{
    public enum QuestionType
    {
        Single,
        Multiple,
        Text
    }

    public class Question
    {
        public string Text { get; set; } = "Undefined";

        public Answer[] Answers { get; set; } = null;

        public QuestionType Type { get; set; } = QuestionType.Text;

        public Question() { }

        public Question(string text, Answer[] answers, QuestionType type = QuestionType.Single)
        {
            Text = text;
            Answers = answers;
            Type = type;
        }
    }
}
