internal class Program
{
    private static void Main(string[] args)
    {
        int wagonsNumber = int.Parse(Console.ReadLine());

        int[] wagons = new int[wagonsNumber];
        int totalCount = 0;

        for (int i = 0; i < wagonsNumber; i++)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            wagons[i] = peopleCount;
            totalCount += peopleCount;
        }

        Console.WriteLine(String.Join(" ", wagons));
        Console.WriteLine(totalCount);
    }
}