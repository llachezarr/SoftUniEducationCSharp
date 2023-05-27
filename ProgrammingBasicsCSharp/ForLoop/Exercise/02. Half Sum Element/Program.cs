using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int biggestNumber = 0;
            int sumOfAllNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input > biggestNumber)
                {
                    biggestNumber = input;
                }

                sumOfAllNumbers += input;
            }

            if (biggestNumber == (sumOfAllNumbers - biggestNumber))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggestNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(biggestNumber - (sumOfAllNumbers - biggestNumber))}");
            }
            
        }
    }
}
