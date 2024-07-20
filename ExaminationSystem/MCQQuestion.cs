using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string questionHeader, string questionBody, double mark, Answer[] answerList, int correctAnswerIndex) : base(questionHeader, questionBody, mark, answerList, correctAnswerIndex)
        {

        }
        public MCQQuestion()
        {

        }
        public override Question CreatQuestion()
        {
            Console.Clear();
            Console.WriteLine("Select the Correct Answer");

            Answer[] answers = new Answer[3];

            double Mark;
            do
            {
                Console.WriteLine("Enter the Mark of the Question");
            }
            while (!double.TryParse(Console.ReadLine(), out Mark) || Mark <= 0);

            string? questionbody;
            do
            {
                Console.WriteLine("Enter the body of the Question");
                questionbody = Console.ReadLine();
            } while (string.IsNullOrEmpty(questionbody));



            for (int i = 0; i < answers.Length; i++)
            {

                string? answertext;
                do
                {
                    Console.Write($"Enter Answer {i + 1}:");
                    answertext = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(answertext));
                answers[i] = new Answer(i + 1, answertext);


            }
            int num;
            do
            {
                Console.WriteLine("Enter the Correct Answer");
            }
            while (!int.TryParse(Console.ReadLine(), out num)||(num<1||num>3));

            Console.Clear();
            return new MCQQuestion("Select the Correct Answer", questionbody, Mark, answers, num);


        }


    }
}