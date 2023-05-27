internal class Program
{
    private static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        bool condition = true;

        if (input % 2 == 0)
        {
            condition = false;
        }

        while (condition)
        {
            Console.WriteLine($"Please write an even number.");
            input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                
                break;
            }
        }

        Console.WriteLine($"The number is: {Math.Abs(input)}");
    }
}