using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nKmCount = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            double priceTaxi = 0;
            double priceBus = 0.09;
            double priceTrain = 0.06;
            double totalPrice = 0;

            switch (dayTime)
            {
                case "day":
                     priceTaxi = 0.79;
                    break;
                case "night":
                     priceTaxi = 0.90;
                    break;
            }

            if (nKmCount >= 20 && nKmCount < 100) {

                totalPrice = priceBus * nKmCount;
            } else if (nKmCount >= 100)
            {
                totalPrice = priceTrain * nKmCount;
            } else
            {
                totalPrice = (priceTaxi * nKmCount) + 0.70;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
