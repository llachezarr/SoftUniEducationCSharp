using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCargo = int.Parse(Console.ReadLine());
            double priceBus = 0;
            double priceТruck = 0;
            double priceTrain = 0;
            double sumCargoBus = 0;
            double sumCargoТruck = 0;
            double sumCargoTrain = 0;
            double sumCargo = 0;

            for (int i = 1; i <= numberOfCargo; i++)
            {
                int theTonnageOfCargo = int.Parse(Console.ReadLine());

                sumCargo += theTonnageOfCargo;

                if (theTonnageOfCargo <= 3)
                {
                    sumCargoBus += theTonnageOfCargo;
                    priceBus += theTonnageOfCargo * 200;
                }

                if (theTonnageOfCargo > 3 && theTonnageOfCargo <= 11)
                {
                    sumCargoТruck += theTonnageOfCargo;
                    priceТruck += theTonnageOfCargo * 175;
                }

                if (theTonnageOfCargo > 11)
                {
                    sumCargoTrain += theTonnageOfCargo;
                    priceTrain += theTonnageOfCargo * 120;
                }
            }

            double sumAveragePrice = (priceBus + priceТruck + priceTrain) / sumCargo;
            double percentCargoMinibus = sumCargoBus / sumCargo * 100;
            double percentCargoTruck = sumCargoТruck / sumCargo * 100;
            double percentCargoTrain = sumCargoTrain / sumCargo * 100;

            Console.WriteLine($"{sumAveragePrice:F2}");
            Console.WriteLine($"{percentCargoMinibus:F2}%");
            Console.WriteLine($"{percentCargoTruck:F2}%");
            Console.WriteLine($"{percentCargoTrain:F2}%");
        }
    }
}
