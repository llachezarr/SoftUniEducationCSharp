using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtInCM = int.Parse(Console.ReadLine());
            int widthInCM = int.Parse(Console.ReadLine());
            int heighInCM = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double percentCalculated = percent / 100;
            double area = lenghtInCM * widthInCM * heighInCM;
            double areaLiters = area * 0.001;
            double litersCapacity = areaLiters - areaLiters * percentCalculated;

            Console.WriteLine(litersCapacity);
        }
    }
}
