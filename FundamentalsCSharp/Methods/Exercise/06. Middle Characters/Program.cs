using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();


        int counter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            counter++;

        }

        PrintMiddle(counter, input);
    }

    private static void PrintMiddle(int counter, string input)
    {
        if (counter % 2 == 0)
        {
            counter /= 2;
            Console.Write(input[counter - 1] + "" + input[counter]);
        }
        else
        {
            counter /= 2;
            Console.WriteLine(input[counter]);
        }
    }
}