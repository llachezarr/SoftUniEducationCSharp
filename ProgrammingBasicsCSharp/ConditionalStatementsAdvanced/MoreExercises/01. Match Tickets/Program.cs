using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double transportPrice = 0;

            switch (type) 
            {
                case "VIP":
                    ticketPrice = 499.99;
                    break;

                case "Normal":
                    ticketPrice = 249.99;
                        break;
            }

            if (peopleCount >= 1 && peopleCount <= 4)
            {
                transportPrice = budget * 0.75;
            }
            else if (peopleCount >= 5 && peopleCount <= 9)
            {
                transportPrice = budget * 0.6;
            }
            else if (peopleCount >= 10 && peopleCount <= 24)
            {
                transportPrice = budget * 0.5;
            }
            else if (peopleCount >= 25 && peopleCount <= 49)
            {
                transportPrice = budget * 0.4;
            }
            else
            {
                transportPrice = budget * 0.25;
            }

            double finalCosts =  transportPrice + (peopleCount * ticketPrice); 

            if (finalCosts <= budget)
            {
                double leftMoney = budget - finalCosts;
                Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
            }
            else
            {
                double neededMoney = finalCosts - budget;
                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
            }
        }
    }
}