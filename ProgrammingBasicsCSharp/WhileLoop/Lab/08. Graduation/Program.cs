using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            int currentGrade = 1;
            int repearts = 0;
            double marksSum = 0;
            bool isExculded = false;

            while (currentGrade <= 12)
            {
                double currentMark = double.Parse(Console.ReadLine());
                if (currentMark < 4)
                {
                    repearts++;

                    if (repearts > 1)
                    {
                        isExculded = true;
                        break;
                    }

                    continue;
                }

                marksSum += currentMark;
                currentGrade++;
            }


            if (isExculded)
            {
                Console.WriteLine($"{studentName} has been excluded at {currentGrade} grade");
            } 
            else
            {
                double averageMark = marksSum / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageMark:F2}");
            }
        }
    }
}
