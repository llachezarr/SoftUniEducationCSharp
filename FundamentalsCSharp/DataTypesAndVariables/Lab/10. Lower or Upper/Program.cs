internal class Program
{
    private static void Main(string[] args)
    {
        char input = Console.ReadLine()[0];

        if (Char.IsUpper(input))
        {
            Console.WriteLine("upper-case");
        }
        else
        {
            Console.WriteLine("lower-case");
        }
    }
}