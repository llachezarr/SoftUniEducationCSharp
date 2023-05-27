using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //Summer / Winter
            string location = "";// "Alaska" и "Morocco".
            string placeType = ""; //"Hotel", "Hut" или "Camp".
            double vacationPrice = 0;

            if (budget <= 1000)
            {
                placeType = "Camp";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        vacationPrice = budget * 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        vacationPrice = budget * 0.45;
                        break;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                placeType = "Hut";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        vacationPrice = budget * 0.8;
                        break;
                    case "Winter":
                        location = "Morocco";
                        vacationPrice = budget * 0.6;
                        break;
                }
            }
            else
            {
                placeType = "Hotel";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        break;
                    case "Winter":
                        location = "Morocco";
                        break;
                }

                vacationPrice = budget * 0.9;
            }

            Console.WriteLine($"{location} - {placeType} - {vacationPrice:F2}");
        }
    }
}
