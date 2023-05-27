using System;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        string command = Console.ReadLine();
        double coins = 0;
        string product = "";
        double price = 0;

        while (command != "Start")
        {
            double coin = double.Parse(command);
            if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
            {
                Console.WriteLine($"Cannot accept {coin}");
            }
            else
            {
                coins += coin;
            }

            command = Console.ReadLine();
        }

        string[] products = { "Nuts", "Water", "Crisps", "Soda", "Coke" };

        while (command != "End")
        {
            if (command != "Nuts" && command != "Water" && command != "Crisps" && command != "Soda" && command != "Coke")
            {
                if (command != "Start")
                {
                    Console.WriteLine("Invalid product");
                }   
            }
            else
            {
                product = command;
                int productIndex = Array.IndexOf(products, product);
                switch (productIndex)
                {
                    case 0:
                        price = 2.0;
                        break;
                    case 1:
                        price = 0.7;
                        break;
                    case 2:
                        price = 1.5;
                        break;
                    case 3:
                        price = 0.8;
                        break;
                    case 4:
                        price = 1.0;
                        break;
                }

                if (price <= coins)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    coins -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"Change: {coins:F2}");
    }
}
