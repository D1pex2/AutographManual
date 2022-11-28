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

        public Stack<Question> Questions { get; }

        public Test(string fileName)
        {
            Questions = new Stack<Question>(XmlHelper.Deserialize<Question[]>(dir+fileName));
        }
    }
}
