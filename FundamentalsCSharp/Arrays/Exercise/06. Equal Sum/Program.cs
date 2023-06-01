internal class Program
{
    private static void Main(string[] args)
    {
        int[] input = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();


    }
}