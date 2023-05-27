using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int totalCake = lenght * width;
            int onePieceOfCake = 1 * 1;

            while (totalCake > 0)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{totalCake / onePieceOfCake} pieces are left.");
                    break;
                }

                int eat = int.Parse(input);
                totalCake -= eat;
            }

            if (totalCake < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalCake)} pieces more.");
            }
        }
    }
}
