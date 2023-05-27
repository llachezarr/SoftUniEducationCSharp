using System;
using System.Security.Cryptography.X509Certificates;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeLenght = int.Parse(Console.ReadLine());
            int brakeLenght = int.Parse(Console.ReadLine());

            double lunchBreak = brakeLenght * (1 / 8.0);
            double restLenght = brakeLenght * (1 / 4.0);

            double totalTime = brakeLenght - lunchBreak - restLenght;

            if (totalTime >= episodeLenght)
            {
                double leftTime = totalTime - episodeLenght;

                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(leftTime)} minutes free time.");
            } else
            {
                double neededTime = episodeLenght - totalTime;

                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(neededTime)} more minutes.");
            }
        }
    }
}
