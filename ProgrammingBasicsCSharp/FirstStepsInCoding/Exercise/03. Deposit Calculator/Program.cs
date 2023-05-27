using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double annualTax = double.Parse(Console.ReadLine());

            double annualTaxPercent = annualTax / 100;
            double totalSum = depositedSum + depositMonths * ((depositedSum * annualTaxPercent) / 12);

            Console.WriteLine(totalSum);
        }
    }
}
