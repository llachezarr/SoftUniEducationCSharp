using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double priceForOneNight = 0;

            switch (roomType)
            {
                case "room for one person":
                    priceForOneNight = 18;
                    break;
                case "apartment":
                    priceForOneNight = 25;
                    break;
                case "president apartment":
                    priceForOneNight = 35;
                    break;
            }

            double totalPrice = priceForOneNight * (daysToStay - 1);

            if ((daysToStay - 1) < 10 && roomType == "apartment")
            {
                totalPrice *= 0.7;
            }
            else if ((daysToStay - 1) >= 10 && daysToStay <= 15 && roomType == "apartment")
            {
                totalPrice *= 0.65;
            }
            else if ((daysToStay - 1) > 15 && roomType == "apartment")
            {
                totalPrice /= 2;
            }
            else if ((daysToStay - 1) < 10 && roomType == "president apartment")
            {
                totalPrice *= 0.9;
            }
            else if ((daysToStay - 1) >= 10 && daysToStay <= 15 && roomType == "president apartment")
            {
                totalPrice *= 0.85;
            }
            else if ((daysToStay - 1) > 15 && roomType == "president apartment")
            {
                totalPrice *= 0.8;
            }

            switch (feedback)
            {
                case "positive":
                    totalPrice *= 1.25;
                    break;
                case "negative":
                    totalPrice *= 0.9;
                    break;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
