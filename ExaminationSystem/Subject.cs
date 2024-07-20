using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Subject
    {


        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public Exam Exam { get; set; }

        public Subject(int SubjectId, string SubjectName)
        {
            this.SubjectId = SubjectId;
            this.SubjectName = SubjectName;

        }
        public void CreateExam()
        {

            uint X;
            do
            {
                Console.WriteLine("Choose type of the Question (1-Final Exam , 2-Practical Exam)");
            }
            while (!uint.TryParse(Console.ReadLine(), out X) || (X < 1 || X > 2));
            if (X == 1)
            {
                this.Exam = new FinalExam();
                Exam = Exam.CreateExam();

            }
            else if (X == 2)
            {

                this.Exam = new PracticalExam();
                this.Exam = Exam.CreateExam();

            }

        }

    }
}