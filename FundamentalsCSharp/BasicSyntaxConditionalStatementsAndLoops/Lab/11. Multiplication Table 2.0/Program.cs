internal class Program
{
    private static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int times = int.Parse(Console.ReadLine());
        int result = 0;

        if (times > 10)
        {
            result = input * times;
            Console.WriteLine($"{input} X {times} = {result}");
        }
        else
        {
            for (int i = times; i <= 10; i++)
            {
                result = input * i;
                Console.WriteLine($"{input} X {i} = {result}");
            }
        }

    }
}