using System;

namespace _08._Sunglasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // горен ред на очилата
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

            // средни n-2 реда на очилата
            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 1) / 2 - 1)
                { // специален ред
                    Console.WriteLine('*' + new string('/', 2 * n - 2) + '*' + new string('|', n) + '*' + new string('/', 2 * n - 2) + '*');
                }
                else
                {
                    Console.WriteLine('*' + new string('/', 2 * n - 2) + '*' + new string(' ', n) + '*' + new string('/', 2 * n - 2) + '*');
                }
            }

            // долен ред на очилата
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

        }
    }
}
