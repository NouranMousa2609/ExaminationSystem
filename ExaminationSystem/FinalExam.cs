using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class FinalExam : Exam
    {

        public Question[] Questions { get; set; }

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
            while (!uint.TryParse(Console.ReadLine(), out time)||time==0);

            uint num;
            do
            {
                Console.WriteLine("Enter number of Questions");
            }
            while (!uint.TryParse(Console.ReadLine(), out num)||num==0);

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
        private protected double CalculateExamGrade()
        {
            {
                double FinalGrade = 0;
                if (Questions is not null)
                {
                    for (int i = 0; i < Questions.Length; i++)
                    {
                        FinalGrade += Questions[i]?.Mark ?? 0;
                    }
                    return FinalGrade;
                }
                return FinalGrade;
            }

        }
        public override void ShowExam()
        {

            double TotalMark = 0;
            for (int i = 0; i < this.NumberOfQuestions; i++)
            {
                TotalMark += Question.ShowQuestion(this.Questions[i]);


            }

            Console.Clear();
            for (int i = 0; i < this.NumberOfQuestions; i++)
            {
                Question.PrintQuestiondWithCorrectAnswers(this.Questions[i]);


            }
            Console.WriteLine($"\nyour Grade in the Final Exam is {TotalMark} from {CalculateExamGrade()}");


        }
    }
}
