using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double totalSum = 0;

            while ((input = Console.ReadLine())!= "NoMoreMoney")
            {
                double sum = double.Parse(input);

                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Math.Abs(totalSum);
                    break;
                }
                Console.WriteLine($"Increase: {sum:F2}");
                totalSum += sum;
            }

            Console.WriteLine($"Total: {totalSum:F2}");
        }
    }
}
