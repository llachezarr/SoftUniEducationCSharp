internal class Program
{
    private static void Main(string[] args)
    {
        string command = Console.ReadLine();
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());


        switch (command)
        {
            case "add":
                Add(n1, n2);
                break;

            case "subtract":
                Subtract(n1, n2);
                break;

            case "multiply":
                Multiply(n1, n2);
                break;

            case "divide":
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    break;
                }
                Divide(n1, n2);
                break;

        }
    }


    private static void Divide(int n1, int n2)
    {
        Console.WriteLine(n1 / (n2 * 1.0));
    }

    private static void Multiply(int n1, int n2)
    {
        Console.WriteLine(n1 * n2);
    }

    private static void Subtract(int n1, int n2)
    {
        Console.WriteLine(n1 - n2);
    }

    private static void  Add(int n1, int n2)
    {
         Console.WriteLine(n1 + n2);
    }
}