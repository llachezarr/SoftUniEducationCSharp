internal class Program
{
    private static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            PrintHalfTriangle(1, i);
        }

        for (int i = input - 1; i >= 1; i--)
        {
            PrintHalfTriangle(1, i);
        }
    }

    private static void PrintHalfTriangle(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}
