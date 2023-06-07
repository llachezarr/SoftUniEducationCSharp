internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int sum = 0;

        foreach (char digitChar in input)
        {
            int digit = int.Parse(digitChar.ToString());
            sum += digit;
        }

        Console.WriteLine(sum);
    }
}