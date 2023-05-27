using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int spendcount = 0;
            int days = 0;

            while (ownedMoney < neededMoney)
            {
                days++;
                string type = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if (type == "spend")
                {
                    spendcount++;
                    ownedMoney -= money;
                    if (spendcount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }

                    if (money > ownedMoney)
                    {
                        ownedMoney = 0;
                    }
                }
                else if (type == "save")
                {
                    spendcount = 0;
                    ownedMoney += money;
                    if (ownedMoney >= neededMoney)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                    }
                }

            }

        }
    }
}
