using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input;
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;


            for (int i = 0; i <+ n; i++) 
            { 
                input = int.Parse(Console.ReadLine());

                if (input < minNumber)
                {
                    minNumber = input;
                }

                if (input > maxNumber)
                { 
                    maxNumber = input;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
