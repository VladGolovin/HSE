﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample
{
    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Answer1 { get; set; }

        public string Answer2 { get; set; }

        public string Answer3 { get; set; }

        public string Answer4 { get; set; }

        public string TrueAnswer { get; set; }

        public int Difficulty { get; set; }
    }
}
