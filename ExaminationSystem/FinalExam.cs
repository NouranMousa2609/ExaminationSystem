using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class FinalExam : Exam
    {

        

        public FinalExam(uint ExamTime, uint NumberOfQuestions) : base(ExamTime, NumberOfQuestions)
        {
           
        }

        public FinalExam()
        {

        }
    }
}
