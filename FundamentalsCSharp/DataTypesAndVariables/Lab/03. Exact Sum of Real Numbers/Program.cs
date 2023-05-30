using System;

class Program
{
    private static void Main(string[] args)
    {
        int times = int.Parse(Console.ReadLine());

        decimal sum = 0;

        for (int i = 0; i < times; i++)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            sum += num;
        }

        Console.WriteLine(sum);
    }
}