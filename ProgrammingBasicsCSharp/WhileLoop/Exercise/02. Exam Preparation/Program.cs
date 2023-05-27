using System;
using System.Reflection.Metadata;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unsatisfayingMarks = int.Parse(Console.ReadLine());
            string input; ;
            int counterMarks = 0;
            int counterBadMarks = 0;
            double marksSum = 0;
            string lastProblem = "";
            bool enough = false;

            while (counterBadMarks != unsatisfayingMarks)
            {
                input = Console.ReadLine();
                if (input == "Enough")
                {
                    enough = true;
                    break;
                }

                lastProblem = input;
                int mark = int.Parse(Console.ReadLine());

                if (mark <= 4)
                {
                    counterBadMarks++;
                }

                marksSum += mark;
                counterMarks++;
            }

            double averageMark = marksSum / counterMarks;

            if (counterBadMarks == unsatisfayingMarks)
            {
                Console.WriteLine($"You need a break, {counterBadMarks} poor grades.");
            }

            if (enough)
            {
                Console.WriteLine($"Average score: {averageMark:F2}");
                Console.WriteLine($"Number of problems: {counterMarks}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
