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
        public override Exam CreateExam()
        {

            uint time;
            do
            {
                Console.WriteLine("Enter time in Minutes");
            }
            while (!uint.TryParse(Console.ReadLine(), out time));

            uint num;
            do
            {
                Console.WriteLine("Enter number of Questions");
            }
            while (!uint.TryParse(Console.ReadLine(), out num));

            MCQQuestion[] qs = new MCQQuestion[num];
            for (int i = 0; i < qs.Length; i++)
            {
                MCQQuestion mCQQuestion = new MCQQuestion();
                qs[i] = (MCQQuestion)mCQQuestion.CreatQuestion();

            }
            Console.Clear();
            return new PracticalExam(time, num, qs);



        }

    }
}   