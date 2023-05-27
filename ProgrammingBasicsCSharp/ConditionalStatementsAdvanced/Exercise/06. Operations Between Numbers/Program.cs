using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operatorSymbol = Console.ReadLine()[0];

            double sum = 0;

            switch (operatorSymbol)
            {
                case '+':
                    sum = n1 + n2;
                    break;

                case '-':
                    sum = n1 - n2;
                    break;

                case '*':
                    sum = n1 * n2;
                    break;

                case '/':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                        break;
                    }
                    sum = n1 / (n2 * 1.0);
                    Console.WriteLine($"{n1} {operatorSymbol} {n2} = {sum:F2}");
                    break;

                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                        break;
                    }
                    sum = n1 % (n2 * 1.0);
                    Console.WriteLine($"{n1} {operatorSymbol} {n2} = {sum}");
                    break;
            }

            if (operatorSymbol == '+' || operatorSymbol == '-' || operatorSymbol == '*') 
            {
                if (sum % 2 == 0) {
                    Console.WriteLine($"{n1} {operatorSymbol} {n2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operatorSymbol} {n2} = {sum} - odd");
                }
            }

        }
    }
}
