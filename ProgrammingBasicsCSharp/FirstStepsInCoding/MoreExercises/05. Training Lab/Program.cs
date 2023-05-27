using System;

namespace _05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            double hInCM = h * 100;
            double wInCM = (w * 100) - 100;
            double placesW = Math.Floor(wInCM / 70);
            double placesH = Math.Floor(hInCM / 120);
            double placesCount = (placesH * placesW) - 3;

            Console.WriteLine(placesCount);
        }
    }
}
