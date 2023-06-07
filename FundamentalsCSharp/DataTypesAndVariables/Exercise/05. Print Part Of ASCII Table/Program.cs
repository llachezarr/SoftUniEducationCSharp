internal class Program
{
    private static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());

        for (int i = start; i <= stop; i++)
        {
            char symbol = (char)i;
            Console.Write(symbol + " ");
        }
    }
}