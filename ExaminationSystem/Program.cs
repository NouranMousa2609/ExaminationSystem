using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main()
        {
            Subject Sub1 = new Subject(10, "c#");
            Sub1.CreateExam();
            
        }
    }
}
