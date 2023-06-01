internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int times = int.Parse(Console.ReadLine());

        Repeater(times, input);
    }

    private static void Repeater(int times, string? input)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write(input);
        }
    }
}