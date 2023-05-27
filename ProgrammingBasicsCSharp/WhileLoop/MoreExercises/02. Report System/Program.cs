using System;
using System.Diagnostics.Tracing;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int neededMoney = int.Parse(Console.ReadLine());

            double totalEarnings = 0;
            double cashEarning = 0;
            double cardEarning = 0;
            int money;
            string input;
            int counter = 1;
            int cardCounter = 0;
            int cashCounter = 0;
            bool end = false;

            while (totalEarnings < neededMoney)
            {
                input = Console.ReadLine();

                if (input == "End")
                {
                    end = true;
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }

                money = int.Parse(input);

                if (counter % 2 == 0 && money >= 10)
                {
                    cardEarning += money;
                    Console.WriteLine("Product sold!");
                    cardCounter++;
                }
               else if (counter % 2 != 0 && money <= 100)
                {
                    cashEarning += money;
                    cashCounter++;
                    Console.WriteLine("Product sold!");
                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                }

                counter++;
                totalEarnings = cashEarning + cardEarning;
            }
            double averageCash = cashEarning / cashCounter;
            double averageCard = cardEarning / cardCounter;

            if (!end)
            {
                Console.WriteLine($"Average CS: {averageCash:F2}");
                Console.WriteLine($"Average CC: {averageCard:F2}");
            }
        }
    }
}
