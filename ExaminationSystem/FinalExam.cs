using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class FinalExam : Exam
    {

        public Question[]? Questions { get; set; }

        public FinalExam(uint ExamTime, uint NumberOfQuestions, Question[] Questions) : base(ExamTime, NumberOfQuestions)
        {
            this.Questions = Questions;

        }

        public FinalExam()
        {

        }
    }
}
