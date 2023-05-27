using Microsoft.VisualBasic;
using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double totalPrice = 0;

            switch (flowerType)
            {
                case "Roses":
                    totalPrice = flowersCount * 5;

                    if (flowersCount > 80)
                    {
                        totalPrice *= 0.9;
                    }
                    break;
                case "Dahlias":
                    totalPrice = flowersCount * 3.8;
                    if (flowersCount > 90)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Tulips":
                    totalPrice = flowersCount * 2.8;
                    if (flowersCount > 80)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Narcissus":
                    totalPrice = flowersCount * 3;
                    if (flowersCount < 120)
                    {
                        totalPrice *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    totalPrice = flowersCount * 2.5;
                    if (flowersCount < 80)
                    {
                        totalPrice *= 1.20;
                    }
                    break;
            }


            if (budget >= totalPrice)
            {
                double leftMoney = budget - totalPrice;

                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {leftMoney:F2} leva left.");
            }
            else
            {
                double neededMoney = totalPrice - budget;

                Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
            }
        }
    }
}
