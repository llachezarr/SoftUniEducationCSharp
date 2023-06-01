using System;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        int result = GetMultipleOfEvenAndOdds(input);
        Console.WriteLine(result);
    }

    static int GetMultipleOfEvenAndOdds(int number)
    {
        int sumEven = GetSumOfEvenDigits(number);
        int sumOdd = GetSumOfOddDigits(number);

        return sumEven * sumOdd;
    }

    static int GetSumOfEvenDigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number);

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }
            number /= 10;
        }

        return sum;
    }

    static int GetSumOfOddDigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number);

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                sum += digit;
            }
            number /= 10;
        }

        return sum;
    }
}