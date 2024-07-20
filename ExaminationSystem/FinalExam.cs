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

            Question[] qs = new Question[num];
            for (int i = 0; i < qs.Length; i++)
            {
                uint X;
                do
                {
                    Console.WriteLine("Choose type of the Question (1-MCQ Question , 2-True OR False Question)");
                }
                while (!uint.TryParse(Console.ReadLine(), out X) || (X < 1 || X > 2));
                Console.Clear();
                if (X == 1)
                {
                    MCQQuestion mCQQuestion = new MCQQuestion();
                    qs[i] = mCQQuestion.CreatQuestion();

                }
                else if (X == 2)
                {

                    TrueOrFalseQuestion trueOrFalseQuestion = new TrueOrFalseQuestion();
                    qs[i] = trueOrFalseQuestion.CreatQuestion();


                }
            }
            Console.Clear();
            return new FinalExam(time, num, qs);

        }
    }
}
