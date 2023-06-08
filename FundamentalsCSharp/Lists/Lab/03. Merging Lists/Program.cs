internal class Program
{
    private static void Main(string[] args)
    {
        List<int> input1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> input2 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> merged = input1.Zip(input2, (x, y) => new[] { x, y })
            .SelectMany(pair => pair)
            .ToList();

        if (input1.Count > input2.Count)
        {
            merged.AddRange(input1.Skip(input2.Count));
        }
        else if (input2.Count > input1.Count)
        {
            merged.AddRange(input2.Skip(input1.Count));
        }

        Console.WriteLine(String.Join(" ", merged));
    }
}