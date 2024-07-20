﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string questionHeader, string questionBody, double mark, Answer[] answerList, int correctAnswer) : base(questionHeader, questionBody, mark, answerList, correctAnswer)
        {

        }
        public TrueOrFalseQuestion()
        {

        }
    }
}
