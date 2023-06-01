internal class Program
{
    private static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        char operatorSymbol = Console.ReadLine()[0];
        int n2 = int.Parse(Console.ReadLine());
        

        Calculator(operatorSymbol, n1, n2);
    }

    private static void Calculator(char operatorSymbol, int n1, int n2)
    {
        double sum = 0;

        switch (operatorSymbol)
        {
            case '+':
                sum = n1 + n2;
                break;

            case '-':
                sum = n1 - n2;
                break;

            case '*':
                sum = n1 * n2;
                break;

            case '/':
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    break;
                }

                sum = n1 / (n2 * 1.0);
                break;
        }

        Console.WriteLine(sum);
    }
}