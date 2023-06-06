internal class Program
{
    private static void Main(string[] args)
    {
        char input1 = Console.ReadLine()[0];
        char input2 = Console.ReadLine()[0];
        char input3 = Console.ReadLine()[0];

        char[] array = new char[] { input1, input2, input3 };


        Console.WriteLine(String.Join("", array));
    }
}