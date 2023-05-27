using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                input = int.Parse(Console.ReadLine());
                sum += input;

            }
            Console.WriteLine(sum);
        }
    }
}
