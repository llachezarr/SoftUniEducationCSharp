using System;

namespace _10._Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dashes = (n - 1) / 2;



            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.Write(new string('-', dashes));
                Console.Write("*");
                var mid = n - 2 * dashes - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', dashes));
                dashes--;
            }
            for (int i = n / 2; i < n; i++)
            {

                Console.Write(new string('-', dashes));
                Console.Write("*");
                var mid = n - 2 * dashes - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', dashes));
                dashes++;

            }
        }
    }
}

