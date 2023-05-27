using System;
using System.Security.Cryptography.X509Certificates;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double shipPrice = 0;
            switch (season)
            {
                case "Spring":
                    shipPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    shipPrice = 4200;
                    break;
                case "Winter":
                    shipPrice = 2600;
                    break;
            }

            if (fishermanCount <= 6)
            {
                shipPrice *= 0.9;
            } 
            else if (fishermanCount <= 11)
            {
                shipPrice *= 0.85;
            } else
            {
                shipPrice *= 0.75;
            }

            if (season != "Autumn" && fishermanCount % 2 == 0)
            {
                shipPrice *= 0.95;
            }

            if (budget >= shipPrice)
            {
                double leftMoney = budget - shipPrice;

                Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
            } 
            else
            {
                double neededMoney = shipPrice - budget;

                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
            }
        }
    }
}
