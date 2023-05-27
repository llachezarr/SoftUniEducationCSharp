using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenuCount = int.Parse(Console.ReadLine());
            int fishMenuCount = int.Parse(Console.ReadLine());
            int vegetarianMenuCount = int.Parse(Console.ReadLine());

            double chickenMenuPrice = chickenMenuCount * 10.35;
            double fishMenuPrice = fishMenuCount * 12.40;
            double vegetarianMenuPrice = vegetarianMenuCount * 8.15;
            double totalPrice = chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice;
            double desertPrice = totalPrice * 0.20;
            double finalPrice = totalPrice + desertPrice + 2.5;

            Console.WriteLine(finalPrice);
        }
    }
}
