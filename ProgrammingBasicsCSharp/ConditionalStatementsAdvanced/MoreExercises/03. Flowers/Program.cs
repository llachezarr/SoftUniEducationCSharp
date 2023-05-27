using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int hyacintsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();//⦁ 	На четвъртия ред е посочен сезона – [Spring, Summer, Аutumn, Winter]
            char isCelebrationDay = Console.ReadLine()[0]; //⦁ 	На петия ред е посочено дали денят е празник – [Y – да / N - не]*/

            double chrysanthemumPrice = 0;
            double rosePrice = 0;
            double hyacintPrice = 0;
            double totalPrice = 0;
            int totalCount = rosesCount + hyacintsCount + chrysanthemumsCount;

            switch (isCelebrationDay)
            {
                case 'Y':
                    switch (season)
                    {
                        case "Spring":
                        case "Summer":
                            chrysanthemumPrice = 2 * 1.15;
                            rosePrice = 4.1 * 1.15;
                            hyacintPrice = 2.5 * 1.15;
                            break;
                        case "Autumn":
                        case "Winter":
                            chrysanthemumPrice = 3.75 * 1.15;
                            rosePrice = 4.5 * 1.15;
                            hyacintPrice = 4.15 * 1.15;
                            break;
                    }
                    break;

                case 'N':
                    switch (season)
                    {
                        case "Spring":
                        case "Summer":
                            chrysanthemumPrice = 2;
                            rosePrice = 4.1;
                            hyacintPrice = 2.5;
                            break;
                        case "Autumn":
                        case "Winter":
                            chrysanthemumPrice = 3.75;
                            rosePrice = 4.5;
                            hyacintPrice = 4.15;
                            break;
                    }
                    break;
            }


            totalPrice = (chrysanthemumsCount * chrysanthemumPrice) + (rosesCount * rosePrice) + (hyacintsCount * hyacintPrice);

            if (season == "Spring" && hyacintsCount > 7)
            {
                totalPrice *= 0.95;
            }
            else if (season == "Winter" && rosesCount >= 10)
            { 
            totalPrice *= 0.9;
            }

            if (totalCount > 20)
            {
                totalPrice *= 0.8;
            }

            Console.WriteLine($"{totalPrice + 2:F2}");
        }
    }
}
