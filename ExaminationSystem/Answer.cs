﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }

        public Answer(int AnswerId, string? AnswerText)
        {
            this.AnswerId = AnswerId;
            this.AnswerText = AnswerText;


        }
        public override string ToString()
        {
            return $"{AnswerId}-{AnswerText}";
        }
    }
}