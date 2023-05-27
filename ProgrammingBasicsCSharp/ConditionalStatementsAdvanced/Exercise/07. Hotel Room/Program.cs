using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int sleepoversCount = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;
            double totalSumStudio = 0;
            double totalSumApartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studio = 50;
                    apartment = 65;
                    break;
                case "June":
                case "September":
                     studio = 75.2;
                     apartment = 68.7;
                    break;
                case "July":
                case "August":
                     studio = 76;
                     apartment = 77;
                    break;
            }

            totalSumStudio = sleepoversCount * studio;
            totalSumApartment = sleepoversCount * apartment;

            if (sleepoversCount > 7 && sleepoversCount <= 14 && (month == "May" || month == "October"))
            {
                totalSumStudio *= 0.95;
            }
            else if (sleepoversCount > 14 && (month == "May" || month == "October"))
            {
                totalSumStudio *= 0.7;
            }
            else if (sleepoversCount > 14 && (month == "June" || month == "September"))
            {
                totalSumStudio *= 0.8;
            }

            if (sleepoversCount > 14)
            {
                totalSumApartment *= 0.9;
            }

            Console.WriteLine($"Apartment: {totalSumApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalSumStudio:F2} lv.");
        }
    }
}
