using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            int totalBottlesInMililiters = bottles * 750;

            int dishCounter = 0;
            int potsConuter = 0;
            int counterWash = 0;

            while (totalBottlesInMililiters >= 0)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                int dirtyDishesAndPots = int.Parse(input);

                counterWash++;

                if (counterWash % 3 == 0)
                {
                    totalBottlesInMililiters -= 15 * dirtyDishesAndPots;
                    potsConuter += dirtyDishesAndPots;
                }
                else
                {
                    totalBottlesInMililiters -= 5 * dirtyDishesAndPots;
                    dishCounter += dirtyDishesAndPots;
                }

     
            }

            if (totalBottlesInMililiters < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(totalBottlesInMililiters)} ml. more necessary!");
            }
            else
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishCounter} dishes and {potsConuter} pots were washed.");
                Console.WriteLine($"Leftover detergent {totalBottlesInMililiters} ml.");
            }
        }
    }
}
