using System;

namespace _07._Christmas_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                // Изчисляваме броя на интервалите и звездичките
                int spacesCount = n - i;
                int starsCount = i;

                // Отпечатваме лява част на елхата
                Console.Write(new string(' ', spacesCount));
                Console.Write(new string('*', starsCount));

                // Отпечатваме средната част на елхата
                Console.Write(" | ");

                // Отпечатваме дясна част на елхата
                Console.Write(new string('*', starsCount));
                Console.Write(new string(' ', spacesCount));

                // Преминаваме на нов ред
                Console.WriteLine();
            }
        }
    }
}
