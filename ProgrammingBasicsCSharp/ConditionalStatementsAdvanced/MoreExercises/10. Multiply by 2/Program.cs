using System;

namespace _10._Multiply_by_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            while (true) 
            {

                input = Console.ReadLine();
                double number = double.Parse(input);
                number *= 2;

                if (number < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Result: {number:F2}");
                }
            }
        }
    }
}