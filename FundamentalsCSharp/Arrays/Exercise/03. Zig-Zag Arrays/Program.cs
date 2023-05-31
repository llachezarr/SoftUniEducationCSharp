﻿internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] arr1 = new string[n];
        string[] arr2 = new string[n];

        for (int i = 1; i <= n; i++)
        {
            string[] input = Console
                .ReadLine()
                .Split()
                .ToArray();

            if (i % 2 != 0)
            {
                arr1[i - 1] = input[0];
                arr2[i - 1] = input[1];
            }

            else
            {
                arr1[i - 1] = input[1];
                arr2[i - 1] = input[0];
            }
        }

        Console.WriteLine(String.Join(" ", arr1));
        Console.WriteLine(String.Join(" ", arr2));
    }
}
