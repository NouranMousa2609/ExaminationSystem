using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class PracticalExam : Exam
    {
        
        public PracticalExam(uint ExamTime, uint NumberOfQuestions, Question[] Questions) : base(ExamTime, NumberOfQuestions,Questions)
        {
           

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
            while (!uint.TryParse(Console.ReadLine(), out time) || time == 0);

            uint num;
            do
            {
                Console.WriteLine("Enter number of Questions");
            }
            while (!uint.TryParse(Console.ReadLine(), out num)||num==0);

            Question[] qs = new Question[num];
            for (int i = 0; i < qs.Length; i++)
            {
                MCQQuestion mCQQuestion = new MCQQuestion();
                qs[i] = mCQQuestion.CreatQuestion();

            }
            Console.Clear();
            return new PracticalExam(time, num, qs);

        }
        public override void ShowExam()
        {

            for (int i = 0; i < this.NumberOfQuestions; i++)
            {

                Console.Write($"Q{i + 1})");
                Question.ShowQuestion(this.Questions[i]);


            }
            Console.Clear();
            Console.WriteLine("Correct answers for the practical Exam");
            for (int i = 0; i < this.NumberOfQuestions; i++)
            {
                Console.Write($"Q{i+1})");
                Question.PrintCorrectAnswers(this.Questions[i]);


            }


        }
    }


}