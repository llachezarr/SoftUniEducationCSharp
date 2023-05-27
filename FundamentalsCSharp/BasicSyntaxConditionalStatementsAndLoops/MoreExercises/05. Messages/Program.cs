internal class Program
{
    private static void Main(string[] args)
    {
        //пререших я от чуждо решение.
        int input = int.Parse(Console.ReadLine());

        string message = "";

        for (int i = 1; i <= input; i++)
        {
            string digits = Console.ReadLine();

            int digitLength = digits.Length;
            int digit = digits[0] - '0';
            int offset = (digit - 2) * 3;

            if (digit == 0)
            {
                message += (char)(digit + 32);
                continue;
            }

            if (digit == 8 || digit == 9)
            {
                offset++;
            }

            int letterIndex = offset + digitLength - 1;
            message += (char)(letterIndex + 97);
        }

        Console.WriteLine(message);
    }
}