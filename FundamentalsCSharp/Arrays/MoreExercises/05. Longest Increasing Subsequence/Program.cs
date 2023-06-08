using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] lis = FindLongestIncreasingSubsequence(numbers);

        Console.WriteLine(string.Join(" ", lis));
    }

    static int[] FindLongestIncreasingSubsequence(int[] numbers)
    {
        int n = numbers.Length;
        int[] lengths = new int[n];
        int[] previousIndices = new int[n];

        int maxLength = 0;
        int lastIndex = -1;

        for (int i = 0; i < n; i++)
        {
            lengths[i] = 1;
            previousIndices[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (numbers[j] < numbers[i] && lengths[j] + 1 > lengths[i])
                {
                    lengths[i] = lengths[j] + 1;
                    previousIndices[i] = j;
                }
            }

            if (lengths[i] > maxLength)
            {
                maxLength = lengths[i];
                lastIndex = i;
            }
        }

        List<int> lis = new List<int>();

        while (lastIndex != -1)
        {
            lis.Add(numbers[lastIndex]);
            lastIndex = previousIndices[lastIndex];
        }

        lis.Reverse();

        return lis.ToArray();
    }
}