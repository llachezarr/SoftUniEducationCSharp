internal class Program
{
    private static void Main(string[] args)
    {
        decimal pounds;

        if (decimal.TryParse(Console.ReadLine(), out pounds))
        {
            decimal dollars = pounds * 1.31m;
            Console.WriteLine($"{dollars:F3}");
        }
    }
}