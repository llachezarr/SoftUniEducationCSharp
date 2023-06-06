using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int[] order = new int[num];

        for (int i = 0; i < num; i++)
        {
            string input = Console.ReadLine();
            int sum = 0;

            foreach (char c in input)
            {
                if (IsVowel(c))
                {
                    sum += (int)c * input.Length;
                }
                else
                {
                    sum += (int)c / input.Length;
                }
            }

            order[i] = sum;
        }

        Array.Sort(order);

        foreach (int number in order)
        {
            Console.WriteLine(number);
        }
    }

    private static bool IsVowel(char c)
    {
        char lowerC = char.ToLower(c);
        return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
    }
}