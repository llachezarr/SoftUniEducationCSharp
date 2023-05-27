using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double magnoliasPriceTotal = magnoliasCount * 3.25;
            double hyacinthsPriceTotal = hyacinthsCount * 4;
            double rosesPriceTotal = rosesCount * 3.5;
            double cactusesPriceTotal = cactusesCount * 8;

            double totalPrice = magnoliasPriceTotal + rosesPriceTotal + hyacinthsPriceTotal + cactusesPriceTotal;




            double finalPrice = totalPrice * 0.95;

            if ( finalPrice >= giftPrice ) {

                double leftMoney = finalPrice - giftPrice;

                Console.WriteLine($"She is left with {Math.Floor(leftMoney)} leva.");
            } else
            {
                double neededMoney = giftPrice - finalPrice;

                Console.WriteLine($"She will have to borrow {Math.Ceiling(neededMoney)} leva.");
            }
        }
    }
}
