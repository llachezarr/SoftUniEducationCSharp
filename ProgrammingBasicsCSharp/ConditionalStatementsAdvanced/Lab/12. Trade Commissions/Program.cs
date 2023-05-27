using System;
using System.Diagnostics;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double commision = double.Parse(Console.ReadLine());

            double result = 0;

            switch (city)
            {
                case "Sofia":
                    if (commision >= 0 && commision <= 500)
                    {
                        result = commision * 0.05;
                    }
                    else if (commision > 500 && commision <= 1000)
                    {
                        result = commision * 0.07;
                    }
                    else if (commision > 1000 && commision <= 10000)
                    {
                        result = commision * 0.08;
                    }
                    else
                    {
                        result = commision * 0.12;
                    }
                    break;
                case "Varna":
                    if (commision >= 0 && commision <= 500)
                    {
                        result = commision * 0.045;
                    }
                    else if (commision > 500 && commision <= 1000)
                    {
                        result = commision * 0.075;
                    }
                    else if (commision > 1000 && commision <= 10000)
                    {
                        result = commision * 0.1;
                    }
                    else
                    {
                        result = commision * 0.13;
                    }
                    break;
                case "Plovdiv":
                    if (commision >= 0 && commision <= 500)
                    {
                        result = commision * 0.055;
                    }
                    else if (commision > 500 && commision <= 1000)
                    {
                        result = commision * 0.08;
                    }
                    else if (commision > 1000 && commision <= 10000)
                    {
                        result = commision * 0.12;
                    }
                    else
                    {
                        result = commision * 0.145;
                    }
                    break;
            }

            if (city == "Sofia" || city == "Varna" || city == "Plovdiv")
            {
                if (commision > 0)
                {
                    Console.WriteLine($"{result:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
