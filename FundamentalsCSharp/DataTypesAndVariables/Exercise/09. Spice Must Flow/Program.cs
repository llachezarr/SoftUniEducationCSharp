internal class Program
{
    private static void Main(string[] args)
    {
        int startingYield = int.Parse(Console.ReadLine());

        int days = 0;
        long totalSpice = 0;

        while (startingYield >= 100)
        {
            totalSpice += startingYield;
            totalSpice -= 26;
            startingYield -= 10;
            days++;
        }

        if (totalSpice >= 26)
        {
            totalSpice -= 26;
        }

        Console.WriteLine(days);
        Console.WriteLine(totalSpice);
    }
}