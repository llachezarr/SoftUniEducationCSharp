using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorCount = int.Parse(Console.ReadLine());
            int seniorCount = int.Parse(Console.ReadLine());
            string typeRace = Console.ReadLine();

            double juniorTax = 0;
            double seniorTax = 0;
            double totalTax = 0;

            switch(typeRace)
            {
                case "trail":
                     juniorTax = 5.5;
                    seniorTax = 7;
                    break;
                case "cross-country":
                    juniorTax = 8;
                    seniorTax = 9.5;
                    break;
                case "downhill":
                     juniorTax = 12.25;
                     seniorTax = 13.75;
                    break;
                case "road":
                    juniorTax = 20;
                    seniorTax = 21.5;
                    break;
            }

            totalTax = juniorCount * juniorTax  + seniorCount * seniorTax;

            if ((seniorCount + juniorCount) >= 50 && typeRace == "cross-country")
            {
                totalTax *= 0.75;
            }

            totalTax *= 0.95;

            Console.WriteLine($"{totalTax:F2}"); 
        }
    }
}
