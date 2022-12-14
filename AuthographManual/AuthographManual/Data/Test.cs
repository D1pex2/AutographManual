using AuthographManual.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthographManual.Data
{
    public class Test
    {
        private string dir = $"{Environment.CurrentDirectory}/Tests/";

        public int Score { get; set; } = 0;

        public int Grade 
        { 
            get
            {
                int percent = (int)Math.Round((double)Score / (double)QuestionQuantity * 100);
                if (percent >= 85)
                {
                    return 5;
                }
                else if (percent >= 75)
                {
                    return 4;
                }
                else if (percent >= 60)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        public Stack<Question> Questions { get; }

        public int QuestionQuantity { get; } = 0;

        public Test(string fileName, int length = -1)
        {
            var questions = XmlHelper.Deserialize<Question[]>(dir + fileName);
            questions.Shuffle();
            if (length <= 0)
            {
                length = questions.Length;
            }
            Questions = new Stack<Question>(questions.Take(length));
            QuestionQuantity = Questions.Count;
        }
    }
}
