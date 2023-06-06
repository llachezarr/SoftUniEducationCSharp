using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] input = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int index = FindEqualSumIndex(input);

        if (index != -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("no");
        }
    }

    static int FindEqualSumIndex(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = 0; j < i; j++)
            {
                leftSum += array[j];
            }

            for (int k = i + 1; k < array.Length; k++)
            {
                rightSum += array[k];
            }

            if (leftSum == rightSum)
            {
                return i;
            }
        }

        return -1;
    }
}