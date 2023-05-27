using System;
using System.Globalization;

namespace _01._Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50 && grade <= 6)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
