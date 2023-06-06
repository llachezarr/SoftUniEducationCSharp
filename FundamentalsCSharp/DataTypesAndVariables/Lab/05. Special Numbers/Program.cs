internal class SpecialNumbers
{
    static bool IsSpecial(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum == 5 || sum == 7 || sum == 11;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i} -> {IsSpecial(i)}");
        }
    }
}