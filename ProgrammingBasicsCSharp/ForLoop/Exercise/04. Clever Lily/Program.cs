using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double savings = 0;
            int toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += i / 2 * 10 - 1;
                }
                else
                {
                    toys++;
                }
            }

            savings += toys * toyPrice;

            if (savings >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savings - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - savings:F2}");
            }
        }
    }
}
