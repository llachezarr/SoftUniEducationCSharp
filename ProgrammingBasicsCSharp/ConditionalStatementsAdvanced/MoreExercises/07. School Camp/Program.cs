using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());

            double priceForOneNight = 0;
            double totalCosts = 0;
            string sportType = "";

            switch (season)
            {
                case "Winter":
                    switch (groupType)
                    {
                        case "boys":
                        case "girls":
                            priceForOneNight = 9.6;
                            break;
                        case "mixed":
                            priceForOneNight = 10;
                            break;
                    }

                    switch (groupType)
                    {
                        case "boys":
                            sportType = "Judo";
                            break;
                        case "girls":
                            sportType = "Gymnastics";
                            break;
                        case "mixed":
                            sportType = "Ski";
                            break;
                    }
                    break;
                case "Spring":
                    switch (groupType)
                    {
                        case "boys":
                        case "girls":
                            priceForOneNight = 7.2;
                            break;
                        case "mixed":
                            priceForOneNight = 9.5;
                            break;
                    }

                    switch (groupType)
                    {
                        case "boys":
                            sportType = "Tennis";
                            break;
                        case "girls":
                            sportType = "Athletics";
                            break;
                        case "mixed":
                            sportType = "Cycling";
                            break;
                    }
                    break;
                case "Summer":
                    switch (groupType)
                    {
                        case "boys":
                        case "girls":
                            priceForOneNight = 15;
                            break;
                        case "mixed":
                            priceForOneNight = 20;
                            break;
                    }

                    switch (groupType)
                    {
                        case "boys":
                            sportType = "Football";
                            break;
                        case "girls":
                            sportType = "Volleyball";
                            break;
                        case "mixed":
                            sportType = "Swimming";
                            break;
                    }
                    break;
            }

            totalCosts = priceForOneNight * studentsCount * nightsCount;

            if (studentsCount >= 50)
            {
                totalCosts *= 0.5;
            }
            else if (studentsCount < 50 && studentsCount >= 20)
            {
                totalCosts *= 0.85;
            }
            else if (studentsCount < 20 && studentsCount >= 10)
            {
                totalCosts *= 0.95;
            }

            Console.WriteLine($"{sportType} {totalCosts:F2} lv.");
        }
    }
}
