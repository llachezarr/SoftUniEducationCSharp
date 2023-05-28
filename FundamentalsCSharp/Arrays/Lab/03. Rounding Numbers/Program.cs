internal class Program
{
    private static void Main(string[] args)
    {
        double[] input = Console
            .ReadLine()
            .Split(" ")
            .Select(double.Parse)
            .ToArray();

        int[] rounded = new int[input.Length];

        for (int i = 0; i < rounded.Length; i++) 
        {
            rounded[i] = (int)Math.Round(input[i], MidpointRounding.AwayFromZero);
            Console.WriteLine($"{input[i]} => {rounded[i]}");
        }

    }
}