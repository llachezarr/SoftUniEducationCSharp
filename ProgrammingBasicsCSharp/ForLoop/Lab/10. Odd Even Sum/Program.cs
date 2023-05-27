using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input;
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                input = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += input;
                }
                else
                {
                    sumOdd += input;
                }

            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine($"Yes \nSum = {sumEven}");
            }
            else
            {
                Console.WriteLine($"No \nDiff = {Math.Abs(sumEven - sumOdd)}");
            }
        }
    }
}
