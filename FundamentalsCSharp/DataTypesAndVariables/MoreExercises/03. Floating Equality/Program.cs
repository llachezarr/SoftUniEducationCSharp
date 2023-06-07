internal class Program
{
    static void Main(string[] args)
    {
        double epsilon = 0.000001;

        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());

        double difference = Math.Abs(numberA - numberB);

        bool areEqual = difference < epsilon;

        Console.WriteLine(areEqual);
    }
}