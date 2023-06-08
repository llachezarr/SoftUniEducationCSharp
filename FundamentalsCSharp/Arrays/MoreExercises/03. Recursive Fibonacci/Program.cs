internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long fibonacciNumber = GetFibonacci(n);
        Console.WriteLine(fibonacciNumber);
    }

    static long GetFibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }

        long[] fibonacciArray = new long[n + 1];
        fibonacciArray[1] = 1;
        fibonacciArray[2] = 1;

        for (int i = 3; i <= n; i++)
        {
            fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
        }

        return fibonacciArray[n];
    }
}