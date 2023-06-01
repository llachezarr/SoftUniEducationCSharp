internal class Program
{
    private static void Main(string[] args)
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        switch (product)
        {
            case "coffee":
                OrderCalculation(product, quantity);
                break;

            case "water":
                OrderCalculation(product, quantity);
                break;

            case "coke":
                OrderCalculation(product, quantity);
                break;

            case "snacks":
                OrderCalculation(product, quantity);
                break;

        }
    }

    private static void OrderCalculation(string product, int quantity)
    {
        if (product == "coffee")
        {
            Console.WriteLine($"{quantity * 1.50:F2}");
        }
        else if (product == "water")
        {
            Console.WriteLine($"{quantity * 1.0:F2}");
        }
        else if (product == "coke")
        {
            Console.WriteLine($"{quantity * 1.40:F2}");
        }
        else if (product == "snacks")
        {
            Console.WriteLine($"{quantity * 2.0:F2}");
        }
    }
}