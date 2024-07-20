using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string questionHeader, string questionBody, double mark, Answer[] answerList, int correctAnswer) : base(questionHeader, questionBody, mark, answerList, correctAnswer)
        {

        }
        public TrueOrFalseQuestion()
        {

        }
        public override Question CreatQuestion()
        {
            Console.WriteLine("select True Or False");
            Answer[] answers = new Answer[2];
            answers[0] = new Answer(1, "true");
            answers[1] = new Answer(2, "false");

            double Mark;
            do
            {
                Console.WriteLine("Enter the Mark of the Question");
            }
            while (!double.TryParse(Console.ReadLine(), out Mark) || Mark < 0);

            string? questionbody;
            do
            {
                Console.WriteLine("Enter the body of the Question");
                questionbody = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(questionbody));


            int num;
            do
            {
                Console.WriteLine("Enter the correct answer ( 1 for True and 2 for False)");
            }
            while (!int.TryParse(Console.ReadLine(), out num) || (num < 1 || num > 2));
            Console.Clear();

            return new TrueOrFalseQuestion("True Or False", questionbody, Mark, answers, num);


        }

    }
}
