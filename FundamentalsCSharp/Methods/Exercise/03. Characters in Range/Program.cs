internal class Program
{
    private static void Main(string[] args)
    {
        string one = Console.ReadLine();
        string two = Console.ReadLine();

        InRange(one, two);
    }

    private static void InRange(string? one, string? two)
    {
        if (char.TryParse(one, out char oneChar) && char.TryParse(two, out char twoChar))
        {
            if (oneChar > twoChar)
            {
                char temp = oneChar;
                oneChar = twoChar;
                twoChar = temp;
            }

            for (char i = (char)(oneChar + 1); i < twoChar; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}