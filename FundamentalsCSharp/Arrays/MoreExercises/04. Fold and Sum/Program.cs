using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int k = numbers.Length / 4;

        int[] upperRow = numbers.Take(k).Reverse().ToArray();
        int[] lowerRow = numbers.Skip(3 * k).Take(k).Reverse().ToArray();

        int[] foldedRow = numbers.Skip(k).Take(2 * k).ToArray();

        int[] upperSum = upperRow.Select((x, i) => x + foldedRow[i]).ToArray();
        int[] lowerSum = lowerRow.Select((x, i) => x + foldedRow[i + k]).ToArray();

        int[] result = upperSum.Concat(lowerSum).ToArray();

        Console.WriteLine(string.Join(" ", result));
    }
}