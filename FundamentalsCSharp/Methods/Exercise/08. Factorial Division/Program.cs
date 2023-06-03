internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        long fact1 = Fact1(num1);
        long fact2 = Fact2(num2);

        double divided = (fact1 * 1.0 / fact2);

        Console.WriteLine($"{divided:F2}");
    }
    static long Fact1(int num1)
    {
        long fact1 = 1;

        for (int i = 1; i <= num1; i++)
        {
            fact1 = fact1 * i;
        }
        return fact1;
    }
    static long Fact2(int num2)
    {
        long fact2 = 1;

        for (int i = 1; i <= num2; i++)
        {
            fact2 = fact2 * i;
        }
        return fact2;
    }
}        