using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string questionHeader, string questionBody, double mark) : base(questionHeader, questionBody, mark)
        {

        }
        public MCQQuestion()
        {

        }
    }
}