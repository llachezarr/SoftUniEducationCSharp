using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine()) ;

            double p1Liters = p1 * h;
            double p2Liters = p2 * h;

            double water = p1Liters + p2Liters;

            if (v >= water)
            {
                double percentFull = water / v * 100;
                double p1Percent = p1Liters / water * 100;
                double p2Percent = p2Liters / water * 100;

                Console.WriteLine($"The pool is {percentFull:F2}% full. Pipe 1: {p1Percent:F2}%. Pipe 2: {p2Percent:F2}%.");
            } else
            {
                double overflow = water - v;

                Console.WriteLine($"For {h:F2} hours the pool overflows with {overflow} liters.");
            }
        }
    }
}
