using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int heigh = int.Parse(Console.ReadLine());

            int totalCapacity = width * lenght * heigh;
            int oneBox = 1 * 1 * 1;

            while (totalCapacity > 0)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    Console.WriteLine($"{totalCapacity / oneBox} Cubic meters left.");
                    break;
                }

                int boxMove = int.Parse(input);
                totalCapacity -= boxMove;
            }

            if (totalCapacity < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(totalCapacity)} Cubic meters more.");
            }
        }
    }
}
