internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();

        char[] inputArr = input.ToCharArray();

        Array.Reverse(inputArr);
        string reversed = new string(inputArr);
        Console.Write(reversed);
    }
}