using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualTax = int.Parse(Console.ReadLine());

            double sneakersPrice = annualTax * 0.6;
            double outfitPrice = sneakersPrice * 0.8;
            double ballPrice = outfitPrice / 4;
            double accesoariesPrice = ballPrice / 5;
            double finalCosts = sneakersPrice + outfitPrice + ballPrice + accesoariesPrice + annualTax;

            Console.WriteLine(finalCosts);
        }
    }
}
