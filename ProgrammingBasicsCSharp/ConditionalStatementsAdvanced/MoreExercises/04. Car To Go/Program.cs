using System;

namespace _04._Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //Summer / Winter
            double carPrice = 0;
            string classType= "";
            string carType = "";
            //car type >> "Cabrio" и "Jeep"

            if (budget <= 100)
            {
                classType = "Economy class";

                switch (season)
                {
                    case "Summer":
                        carType = "Cabrio";
                        carPrice = budget * 0.35;
                        break;
                    case "Winter":
                        carType = "Jeep";
                        carPrice = budget * 0.65;
                        break;           
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                classType = "Compact class";

                switch (season)
                {
                    case "Summer":
                        carType = "Cabrio";
                        carPrice = budget * 0.45;
                        break;
                    case "Winter":
                        carType = "Jeep";
                        carPrice = budget * 0.8;
                        break;
                }
            }
            else
            {
                classType = "Luxury class";

                carType = "Jeep";
                carPrice = budget * 0.9;
            }

            Console.WriteLine($"{classType}");
            Console.WriteLine($"{carType} - {carPrice:F2}");
        }
    }
}
