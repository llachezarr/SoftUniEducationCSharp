using System;

namespace _06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerelPriceInKg = double.Parse(Console.ReadLine());
            double sprinklePriceInKg = double.Parse(Console.ReadLine());
            double bonitoInKg = double.Parse(Console.ReadLine());
            double safridInKg = double.Parse(Console.ReadLine());
            int clamsKG = int.Parse(Console.ReadLine());

            double clamsPriceTotal = clamsKG * 7.5;
            double bonitoPriceTotal = bonitoInKg * (mackerelPriceInKg * 1.6);
            double safridPriceTotal = safridInKg * (sprinklePriceInKg * 1.8);

            double finalPrice = clamsPriceTotal + bonitoPriceTotal + safridPriceTotal;

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
