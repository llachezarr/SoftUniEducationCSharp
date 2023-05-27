using System.Numerics;

internal class Program
{
    public static void Order(ref int a, ref int b)
    {
        int tempNum = a;
        a = b;
        b = tempNum;
    }
    private static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if (num1 < num2)
        {
            Order(ref num1, ref num2);
        }
        if (num2 < num3)
        {
            Order(ref num2, ref num3);
        }
        if (num1 < num2)
        {
            Order(ref num1, ref num2);
        }

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
    }
}