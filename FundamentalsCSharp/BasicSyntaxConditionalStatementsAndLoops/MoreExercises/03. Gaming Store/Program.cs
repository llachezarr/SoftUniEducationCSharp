internal class Program
{
    private static void Main(string[] args)
    {
        double currentBalance = double.Parse(Console.ReadLine());

        double balanceMemory = currentBalance;

        string input = "";
        double price = 0;
        bool name = false;

        while (input != "Game Time")
        {
            input = Console.ReadLine();

            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                break;
            }
            else if (input == "Game Time")
            {
                double spentMoney = balanceMemory - currentBalance;
                Console.Write($"Total spent: ${spentMoney:F2}. Remaining: ${currentBalance:F2}");
                break;
            }

            switch (input)
            {
                case "OutFall 4":
                case "RoverWatch Origins Edition":
                    price = 39.99;
                    name = true;
                    break;
                case "CS: OG":
                    price = 15.99;
                    name = true;
                    break;
                case "Zplinter Zell":
                    price = 19.99;
                    name = true;
                    break;
                case "Honored 2":
                    price = 59.99;
                    name = true;
                    break;
                case "RoverWatch":
                    price = 29.99;
                    name = true;
                    break;
                default:
                    name = false;
                    break;
            }

            if (name && price <= currentBalance)
            {
                Console.WriteLine($"Bought {input}");
                currentBalance -= price;
            }
            else if (name && price > currentBalance)
            {
                Console.WriteLine("Too Expensive");
            }
            else if (!name && input != "Game Time")
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}