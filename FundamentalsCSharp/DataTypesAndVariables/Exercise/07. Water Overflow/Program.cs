using System;

internal class Program
{
    public const int capacity = 255;

    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sumLiters = 0;

        for (int i = 0; i < n; i++)
        {
            int liters = int.Parse(Console.ReadLine());

            if (sumLiters + liters > capacity)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            else
            {
                sumLiters += liters;
            }
        }

        Console.WriteLine(sumLiters);
    }
}