using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xSquareMeters = int.Parse(Console.ReadLine());
            double yGrapeforOneSquareMeter = double.Parse(Console.ReadLine());
            int zNeededLitersWine = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double totalGrape = xSquareMeters * yGrapeforOneSquareMeter;
            double totalWine = (totalGrape * 0.40) / 2.5;
            double restWine = totalWine - zNeededLitersWine;
            double wineForOneWorker = restWine / workersCount;

            if (totalWine >= zNeededLitersWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
                Console.WriteLine($"{Math.Abs(Math.Ceiling(restWine))} liters left -> {Math.Ceiling(wineForOneWorker)} liters per person.");
            } else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(zNeededLitersWine - totalWine)} liters wine needed.");
            }
        }
    }
}
