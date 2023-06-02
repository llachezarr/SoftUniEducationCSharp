internal class Program
{
    private static void Main()
    {
        string input = Console.ReadLine();


        int vowelCount = CountVowels(input);

        Console.WriteLine(vowelCount);
    }

    public static int CountVowels(string input)
    {
        int count = 0;
        foreach (char c in input.ToLower())
        {
            if (IsVowel(c))
                count++;
        }
        return count;
    }

    public static bool IsVowel(char c)
    {
        c = Char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}