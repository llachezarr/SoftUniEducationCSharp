internal class Program
{
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(AreaRectangle(a, b));
    }

    private static int AreaRectangle(int a, int b)
    {
        return a * b;
    }
}