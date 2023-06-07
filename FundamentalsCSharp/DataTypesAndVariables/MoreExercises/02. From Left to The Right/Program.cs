internal class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');

            long leftNumber = long.Parse(numbers[0]);
            long rightNumber = long.Parse(numbers[1]);

            long sum = leftNumber > rightNumber ? SumOfDigits(leftNumber) : SumOfDigits(rightNumber);

            Console.WriteLine(sum);
        }
    }

    static long SumOfDigits(long number)
    {
        long sum = 0;
        number = Math.Abs(number);

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}