using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPackPensils = int.Parse(Console.ReadLine());
            int countPackMarkers = int.Parse(Console.ReadLine());
            int litersCleaner = int.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            double pensilsPrice = countPackPensils * 5.80;
            double markersPrice = countPackMarkers * 7.20;
            double cleanersPrice = litersCleaner * 1.20;
            double discount = discountPercent / 100.0;
            double totalSum = pensilsPrice + markersPrice + cleanersPrice;
            double finalSum = totalSum - totalSum * discount;

            Console.WriteLine(finalSum);
        }
    }
}
