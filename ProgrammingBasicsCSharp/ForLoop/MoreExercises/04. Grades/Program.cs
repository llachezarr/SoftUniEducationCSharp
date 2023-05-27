using System;

namespace _04._Grades
{
        internal class Program
        {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double top = 0;
            double between4And499 = 0;
            double between3And399 = 0;
            double fail = 0;
            double sum = 0;
            double average = 0;

            for (int i = 0; i < n; i++)
            {
                double mark = double.Parse(Console.ReadLine());

                sum += mark;

                if (mark >= 5)
                {
                    top++;
                }
                else if (mark >= 4.0)
                {
                    between4And499++;
                }
                else if (mark >= 3.0)
                {
                    between3And399++;
                }
                else
                {
                    fail++;
                }
            }

            top = (top / n) * 100;
            between4And499 = (between4And499 / n) * 100;
            between3And399 = (between3And399 / n) * 100;
            fail = (fail / n) * 100;
            average = sum / n;

            Console.WriteLine($"Top students: {top:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4And499:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3And399:F2}%");
            Console.WriteLine($"Fail: {fail:F2}%");
            Console.WriteLine($"Average: {average:F2}");
        }
    }
}
