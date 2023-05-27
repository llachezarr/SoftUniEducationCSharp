using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmForOneMonth = double.Parse(Console.ReadLine());

            double kmForOneSeason = kmForOneMonth * 4;
            double paymentForOneKm = 0;
            double totalSalary = 0;


            if (kmForOneMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        paymentForOneKm = 0.75;
                        break;
                    case "Summer":
                        paymentForOneKm = 0.9;
                        break;
                    case "Winter":
                        paymentForOneKm = 1.05;
                        break;
                }
            }
            else if (kmForOneMonth > 5000 && kmForOneMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        paymentForOneKm = 0.95;
                        break;
                    case "Summer":
                        paymentForOneKm = 1.10;
                        break;
                    case "Winter":
                        paymentForOneKm = 1.25;
                        break;
                }
            }
            else if (kmForOneMonth > 10000 && kmForOneMonth <= 20000)
            {
                paymentForOneKm = 1.45;
            }

            totalSalary = paymentForOneKm * kmForOneSeason;


            totalSalary *= 0.9; //taxes

            Console.WriteLine($"{totalSalary:F2}");
        }
    }
}
