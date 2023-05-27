using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int rolls = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int totalPlaces = rolls * columns;
            double totalIncomes = 0;

            switch (typeOfProjection)
            {
                case "Premiere":
                    totalIncomes = totalPlaces * 12;
                    break;
                case "Normal":
                    totalIncomes = totalPlaces * 7.5;
                        break;
                case "Discount":
                    totalIncomes = totalPlaces * 5;
                    break;
            }

            Console.WriteLine($"{totalIncomes:F2}");
        }
    }
}
