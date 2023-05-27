using System;

//I have used chatbot ai because i cant find out how to solve this mathematic problem. And now i know the answer of the question in math classes "where i'll need this in my life" :D

internal class Program
{
    private static int GetFactorial(int number)
    {
        int factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    private static bool IsStrongNumber(int number)
    {
        int temp = number;
        int sum = 0;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += GetFactorial(digit);
            temp /= 10;
        }
        return sum == number;
    }

    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if (IsStrongNumber(number))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}