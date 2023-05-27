using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        int num = 1;
        int sum = 0;

        while (count < n)
        {
            Console.WriteLine(num);
            sum += num;
            num += 2;
            count++;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}