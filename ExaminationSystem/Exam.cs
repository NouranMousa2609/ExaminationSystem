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

        protected Exam(uint ExamTime, uint NumberOfQuestions)
        {
            this.ExamTime = ExamTime;
            this.NumberOfQuestions = NumberOfQuestions;

        }
        protected Exam()
        {

        }
       

    }
}
