﻿public class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        string result = GetProductSign(num1, num2, num3);
        Console.WriteLine(result);
    }

    static string GetProductSign(int num1, int num2, int num3)
    {
        bool hasNegative = (num1 < 0) ^ (num2 < 0) ^ (num3 < 0);
        if (num1 == 0 || num2 == 0 || num3 == 0)
        {
            return "zero";
        }
        else if (hasNegative)
        {
            return "negative";
        }
        else
        {
            return "positive";
        }
    }
}