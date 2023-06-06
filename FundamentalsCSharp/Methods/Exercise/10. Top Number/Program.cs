using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        PrintTopNumbers(n);
    }

    static bool IsTopNumber(int num)
    {
        int digitSum = 0;
        bool hasOddDigit = false;

        foreach (char digitChar in num.ToString())
        {
            int digit = int.Parse(digitChar.ToString());
            digitSum += digit;
            if (digit % 2 != 0)
            {
                hasOddDigit = true;
            }
        }

        return digitSum % 8 == 0 && hasOddDigit;
    }

    static void PrintTopNumbers(int n)
    {
        for (int num = 1; num <= n; num++)
        {
            if (IsTopNumber(num))
            {
                Console.WriteLine(num);
            }
        }
    }
}