﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthographManual.Data
{
    public class Answer
    {
        public string Text { get; }

        public bool IsRight { get; }

        public Answer(string text, bool isRigth = false)
        {
            Text = text;
            IsRight = isRigth;
        }
    }
}
