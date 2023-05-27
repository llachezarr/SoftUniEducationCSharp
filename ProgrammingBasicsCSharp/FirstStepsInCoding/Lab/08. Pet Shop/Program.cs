using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodCount = int.Parse(Console.ReadLine());
            int catFoodCount = int.Parse(Console.ReadLine());

            double finalPrice = dogFoodCount * 2.5 + catFoodCount * 4;

            Console.WriteLine($"{finalPrice} lv.");
        }
    }
}
