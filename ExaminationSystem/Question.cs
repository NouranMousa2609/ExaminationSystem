using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{

   abstract class Question
   {

       public string? QuestionHeader { get; set; }

       public string? QuestionBody { get; set; }

       public Double Mark { get; set; }

        public Answer[] AnswerList { get; set; }

        public int CorrectAnswer { get; set; }

        protected Question()
        {

        }
        protected Question(string questionHeader, string questionBody, double mark, Answer[] answerList, int correctAnswer)
        {
            QuestionHeader = questionHeader;
            QuestionBody = questionBody;
            Mark = mark;
            AnswerList = answerList;
            CorrectAnswer = correctAnswer;
        }

        public abstract Question CreatQuestion();

        public static double ShowQuestion(Question Q)
        {

            Console.WriteLine($"{Q.QuestionHeader}\t ({Q.Mark} Marks)");
            Console.WriteLine(Q.QuestionBody);
            Console.WriteLine();
            for (int i = 0; i < Q.AnswerList.Length; i++)
            {
                Console.WriteLine(Q.AnswerList[i]);

            }
            Console.WriteLine("____________________________________");
            int numA;
            do
            {
                Console.WriteLine("enter number of the answer");
            } while (!int.TryParse(Console.ReadLine(), out numA)||(numA<1||numA>3));
            Console.Clear();
            if (numA == Q.CorrectAnswer)
            {
                return Q.Mark;
            }
            else return 0;

        }

        public static void PrintCorrectAnswers(Question Q)
        {
            Console.WriteLine(Q.AnswerList[Q.CorrectAnswer - 1]);


        }
        public static void PrintQuestiondWithCorrectAnswers(Question Q)
        {
            Console.WriteLine(Q.QuestionBody);
            Console.WriteLine($"Correct Answer is {Q.AnswerList[Q.CorrectAnswer - 1]}");


        }

    }

}
