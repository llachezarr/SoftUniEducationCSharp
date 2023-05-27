using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearMustLive = int.Parse(Console.ReadLine());

            int years = 18;

            for (int i = 1800; i <= yearMustLive; i++)
            {
                if (i % 2 == 0)
                {
                    inheritedMoney -= 12000;
                    years++;
                }
                else
                {
                    inheritedMoney -= 12000 + (50 * years);
                    years++;
                }
            }

            if (inheritedMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):F2} dollars to survive.");
            }
        }
    }
}
