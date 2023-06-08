using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        input.RemoveAll(x => x < 0);

        input.Reverse();

        if (input.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(String.Join(" ", input));
        }
    }
}