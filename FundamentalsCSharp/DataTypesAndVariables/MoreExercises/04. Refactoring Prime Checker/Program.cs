﻿internal class Program
{
    private static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        for (int i = 2; i <= count; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{i} -> true");
            }
            else
            {
                Console.WriteLine($"{i} -> false");
            }
        }
    }
}