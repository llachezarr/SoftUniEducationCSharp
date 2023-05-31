using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console
            .ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        int[] output = new int[input.Length];
        int topIntegersCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            bool isTopInteger = true;

            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] <= input[j])
                {
                    isTopInteger = false;
                    break;
                }
            }

            if (isTopInteger)
            {
                output[topIntegersCount] = input[i];
                topIntegersCount++;
            }
        }

        Array.Resize(ref output, topIntegersCount);

        Console.WriteLine(string.Join(" ", output));
    }
}