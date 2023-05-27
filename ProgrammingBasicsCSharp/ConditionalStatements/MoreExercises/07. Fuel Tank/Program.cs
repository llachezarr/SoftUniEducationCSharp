using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine(); 
            double litersInside = double.Parse(Console.ReadLine());

            switch (fuelType)
            {
                case "Gasoline":

                    fuelType = "gasoline";

                    if (litersInside >= 25)
                    {
                        Console.WriteLine($"You have enough {fuelType}.");
                    }
                    else
                    {
                        Console.WriteLine($"Fill your tank with {fuelType}!");
                    }
                    break;

                case "Gas":

                    fuelType = "gas";

                    if (litersInside >= 25)
                    {
                        Console.WriteLine($"You have enough {fuelType}.");
                    }
                    else
                    {
                        Console.WriteLine($"Fill your tank with {fuelType}!");
                    }

                    break;

                case "Diesel":

                    fuelType = "diesel";

                    if (litersInside >= 25)
                    {
                        Console.WriteLine($"You have enough {fuelType}.");
                    } else
                    {
                        Console.WriteLine($"Fill your tank with {fuelType}!");
                    }

                    break;

                default:

                    Console.WriteLine("Invalid fuel!");

                    break;
            }
        }
    }
}
