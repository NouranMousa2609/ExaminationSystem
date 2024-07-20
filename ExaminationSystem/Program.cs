using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main()
        {
            Subject Sub1 = new Subject(10, "c#");
            Sub1.CreateExam();
            Console.Clear();

            Console.Write("Do You Want To Start The Exam (y | n): ");
            char C;
            if (char.TryParse(Console.ReadLine(), out C) && (C == 'y' || C == 'Y'))

            {
                Console.Clear();
                Stopwatch SW = new Stopwatch();
                SW.Start();
                Sub1?.Exam?.ShowExam();
                Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");
            }
        }
    }
}
