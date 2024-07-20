using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    abstract class Exam
    {

        public uint ExamTime { get; set; }
        public uint NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        protected Exam(uint ExamTime, uint NumberOfQuestions, Question[] questions)
        {
            this.ExamTime = ExamTime;
            this.NumberOfQuestions = NumberOfQuestions;
            Questions = questions;
        }
        protected Exam()
        {

        }
        public abstract Exam CreateExam();
        public abstract void ShowExam();
    }
}
