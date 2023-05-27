using System;

namespace _10._Weather_Forecast___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degreeInput = double.Parse(Console.ReadLine());

            if (degreeInput >= 26 && degreeInput <= 35)
            {
                Console.WriteLine("Hot");
            }
            else if (degreeInput >= 20.1 && degreeInput <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degreeInput >= 15 && degreeInput <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (degreeInput >= 12 && degreeInput <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degreeInput >= 5 && degreeInput <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
