using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string questionHeader, string questionBody, double mark, Answer[] answerList, int correctAnswerIndex) : base(questionHeader, questionBody, mark, answerList, correctAnswerIndex)
        {

        }
        public MCQQuestion()
        {

        }
    }
}