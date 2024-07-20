using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class PracticalExam : Exam
    {
        public MCQQuestion[] Mcq { get; set; }
        public PracticalExam(uint ExamTime, uint NumberOfQuestions, MCQQuestion[] Mcq) : base(ExamTime, NumberOfQuestions)
        {
            this.Mcq = Mcq;

        }
        public PracticalExam()
        {

        }

    }
}   