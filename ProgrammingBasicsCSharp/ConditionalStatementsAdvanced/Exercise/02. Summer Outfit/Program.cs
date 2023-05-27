using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            switch (dayTime)
            {
                case "Morning":

                    if (degree >= 10 && degree <= 18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Sweatshirt and Sneakers.");
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    else
                    {
                        Console.WriteLine($"It's {degree} degrees, get your T-Shirt and Sandals.");
                    }
                    break;
                case "Afternoon":
                    if (degree >= 10 && degree <= 18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your T-Shirt and Sandals.");
                    }
                    else
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Swim Suit and Barefoot.");
                    }
                    break;
                case "Evening":

                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    break;
            }
        }
    }
}
