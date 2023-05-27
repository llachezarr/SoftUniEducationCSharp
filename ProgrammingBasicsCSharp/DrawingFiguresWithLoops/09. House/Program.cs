using System;

namespace _09._House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            for (int row = 0; row < (n + 1) / 2; row++)
            {
                int dashes = (n - stars) / 2;
                Console.Write(new string('-', dashes));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', dashes));
                Console.WriteLine();
                stars = stars + 2;
            }
            int bodyrows = n - (n + 1) / 2;
            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");

            }
        }
    }
}
