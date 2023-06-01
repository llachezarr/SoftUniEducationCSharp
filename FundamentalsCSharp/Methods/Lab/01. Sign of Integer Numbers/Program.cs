internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        SignNumber(number);
    }

    private static void SignNumber(int number)
    {
        if (number == 0)
        {
            Console.WriteLine($"The number {number} is zero.");
        }
        else if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {number} is negative.");
        }
    }
}