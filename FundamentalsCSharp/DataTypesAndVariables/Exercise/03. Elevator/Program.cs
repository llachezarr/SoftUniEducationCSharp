internal class Program
{
    private static void Main(string[] args)
    {
        int peopleCount = int.Parse(Console.ReadLine());
        int elevatorCapacity = int.Parse(Console.ReadLine());

        double result = peopleCount / (double)elevatorCapacity;
        Console.WriteLine(Math.Ceiling(result));
    }
}