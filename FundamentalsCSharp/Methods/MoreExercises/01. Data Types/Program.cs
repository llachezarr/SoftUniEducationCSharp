internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();

        Logic(input);

    }

    private static void Logic(string? input)
    {
        int inputInt;
        double inputReal;

        switch (input)
        {
            case "int":
                inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine(inputInt * 2);
                break;
            case "real":
                inputReal = double.Parse(Console.ReadLine());
                Console.WriteLine($"{inputReal * 1.5:F2}");
                break;
            case "string":
                input = Console.ReadLine();
                Console.WriteLine($"${input}$");
                break;
        }
    }
}