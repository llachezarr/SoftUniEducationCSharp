using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double gpuPrice = 250;
            double gpuPriceTotal = gpuPrice * gpuCount;

            double cpuPrice = gpuPriceTotal * 0.35;
            double ramPrice = gpuPriceTotal * 0.1;

            double finalCosts = gpuPriceTotal + cpuCount * cpuPrice + ramCount * ramPrice;


            if (gpuCount > cpuCount)
            {
                finalCosts *= 0.85;
            }

            if (budget >= finalCosts)
            {
                double leftMoney = budget - finalCosts;

                Console.WriteLine($"You have {leftMoney:F2} leva left!");
            }
            else 
            {
                double neededMoney = finalCosts - budget;

                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
            }
        }
    }
}
