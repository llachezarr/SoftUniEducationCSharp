using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";

                switch (season)
                {
                    case "summer":
                        place = "Camp";
                        budget *= 0.3;
                        break;
                    case "winter":
                        place = "Hotel";
                        budget *= 0.7;
                        break;
                }
                //bg

            } else if (budget <= 1000)
            {
                destination = "Balkans";

                switch (season)
                {
                    case "summer":
                        place = "Camp";
                        budget *= 0.4;
                        break;
                    case "winter":
                        place = "Hotel";
                        budget *= 0.8;
                        break;
                }
            } 
            else
            {
                destination = "Europe";

                switch (season)
                {
                    case "summer":
                    case "winter":
                        place = "Hotel";
                        budget *= 0.9;
                        break;
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {budget:F2}");
        }
    }
}
