﻿internal class Program
{
    private static void Main(string[] args)
    {
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
                for (int j = 1; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("");
            }
        }
    }
}