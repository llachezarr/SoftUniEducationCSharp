internal class Program
{
    private static void Main(string[] args)
    {
        int quantity = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i < quantity; i++)
        {
            char input = Console.ReadLine()[0];

            sum += input;
        }



        Console.WriteLine($"The sum equals: {sum}");
    }
}