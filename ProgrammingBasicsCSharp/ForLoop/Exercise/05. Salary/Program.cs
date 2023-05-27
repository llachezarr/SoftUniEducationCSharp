using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            string input;

            for (int i = 1; i <= openTabs; i++)
            {
                /*  ⦁	"Facebook" -> 150 лв.
                    ⦁	"Instagram" -> 100 лв.
                    ⦁	"Reddit" -> 50 лв.
                */
                input = Console.ReadLine();

                if (input == "Facebook")
                {
                    salary -= 150;
                }
                else if (input == "Instagram")
                {
                    salary -= 100;
                }
                else if (input == "Reddit")
                {
                    salary -= 50;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{salary:F0}");
            }
        }
    }
}
