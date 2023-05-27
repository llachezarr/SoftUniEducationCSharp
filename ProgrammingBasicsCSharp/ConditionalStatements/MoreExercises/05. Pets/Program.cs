using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());
            double dogFoodPerDayInKg = double.Parse(Console.ReadLine());
            double catFoodPerDayInKg = double.Parse(Console.ReadLine());
            double turtleFoodPerDayInGrams = double.Parse(Console.ReadLine());

            double dogFoodTotal = dogFoodPerDayInKg * daysCount;
            double catFoodTotal = catFoodPerDayInKg * daysCount;
            double turtleFoodTotal = (turtleFoodPerDayInGrams / 1000) * daysCount;

            double totalFood = dogFoodTotal + catFoodTotal + turtleFoodTotal;
            double restFood = leftFood - totalFood;

            if (totalFood <= leftFood)
            {
                Console.WriteLine($"{Math.Floor(restFood)} kilos of food left.");
            } else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - leftFood)} more kilos of food are needed.");
            }
        }
    }
}
