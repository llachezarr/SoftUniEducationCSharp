using System;
using System.Runtime.ConstrainedExecution;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());

            int puzzlesCount = int.Parse(Console.ReadLine());
            int speakingDollsCount = int.Parse(Console.ReadLine());
            int softBearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double puzzlesPriceTotal = puzzlesCount * 2.6;
            double speakingDollsPriceTotal = speakingDollsCount * 3;
            double softBearsPriceTotal = softBearsCount * 4.1;
            double minionsPriceTotal = minionsCount * 8.2;
            double trucksPriceTotal = trucksCount * 2;

            double totalCount = speakingDollsCount + speakingDollsCount + softBearsCount + minionsCount + trucksCount;
            double finalPrice = puzzlesPriceTotal + speakingDollsPriceTotal + softBearsPriceTotal + minionsPriceTotal + trucksPriceTotal;

            if (totalCount >= 50)
            {
                finalPrice *= 0.75;
            }

            finalPrice *= 0.90;

            if (finalPrice >= tripPrice)
            {
                double leftMoney = finalPrice - tripPrice;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            } else
            {
                double neededMoney = tripPrice - finalPrice;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
        }
    }
}
