using System;

namespace _04._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForKgVegetables = double.Parse(Console.ReadLine());
            double priceForKgFruits = double.Parse(Console.ReadLine());
            double totalKgVegetables = int.Parse(Console.ReadLine());
            double totalKgFruits = int.Parse(Console.ReadLine());

            double totalIncomes = priceForKgFruits * totalKgFruits + priceForKgVegetables * totalKgVegetables;

            double totalIncomesInEuro = totalIncomes / 1.94;

            Console.WriteLine($"{totalIncomesInEuro:F2}");
        }
    }
}
