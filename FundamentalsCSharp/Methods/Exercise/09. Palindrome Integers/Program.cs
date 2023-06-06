internal class Program
{
    public static void Main(string[] args)
    {
        string input = "";

        while (input != "END")
        {
            input = Console.ReadLine();

            var reversedStr = ReversedStr(input);

            if (Output(input, reversedStr)) break;
        }
    }

    private static bool Output(string? input, string reversedStr)
    {
        if (input == "END")
        {
            return true;
        }
        else
        {
            if (input.Equals(reversedStr))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        return false;
    }

    private static string ReversedStr(string? input)
    {
        char[] stringArray = input.ToCharArray();
        Array.Reverse(stringArray);
        string reversedStr = new string(stringArray);
        return reversedStr;
    }
}