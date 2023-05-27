using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int statistsCount = int.Parse(Console.ReadLine());
            double statistOutfitPrice = double.Parse(Console.ReadLine());

            double decorPrice = movieBudget * 0.1;
            double statistsOutfitTotalPrice = statistOutfitPrice * statistsCount;

            if (statistsCount > 150)
            {
                statistsOutfitTotalPrice *= 0.90;
            }

            double finalCosts = decorPrice + statistsOutfitTotalPrice;

            if (finalCosts <= movieBudget)
            {
                double leftMoney = movieBudget - finalCosts;

                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
            }
            else
            {
                double neededMoney = finalCosts - movieBudget;

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
            }
        }
    }
}
