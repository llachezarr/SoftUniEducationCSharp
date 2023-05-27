using System;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubcard = Console.ReadLine();

            double totalFuel = 0;

            if (clubcard == "Yes")
            {
                switch (fuelType)
                {
                    case "Gasoline":
                        totalFuel = fuelQuantity * (2.22 - 0.18);
                        break;
                    case "Diesel":
                        totalFuel = fuelQuantity * (2.33 - 0.12);
                        break;
                    case "Gas":
                        totalFuel = fuelQuantity * (0.93 - 0.08);
                        break;
                }
            }
            else if (clubcard == "No")
            {
                switch (fuelType)
                {
                    case "Gasoline":
                        totalFuel = fuelQuantity * 2.22;
                        break;
                    case "Diesel":
                        totalFuel = fuelQuantity * 2.33;
                        break;
                    case "Gas":
                        totalFuel = fuelQuantity * 0.93;
                        break;
                }
            }

            if (fuelQuantity >= 20 && fuelQuantity <= 25)
            {
                totalFuel *= 0.92;
            }
            else if (fuelQuantity > 25)
            {
                totalFuel *= 0.90;
            }

            Console.WriteLine($"{totalFuel:F2} lv.");
        }
    }
}
