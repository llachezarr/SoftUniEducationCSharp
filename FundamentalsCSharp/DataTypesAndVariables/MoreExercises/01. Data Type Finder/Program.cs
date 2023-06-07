internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();

        while (input != "END")
        {
            bool isInteger = int.TryParse(input, out int integerValue);
            bool isFloatingPoint = double.TryParse(input, out double floatingPointValue);
            bool isBoolean = bool.TryParse(input, out bool booleanValue);

            if (isInteger)
            {
                Console.WriteLine($"{input} is integer type");
            }
            else if (isFloatingPoint)
            {
                Console.WriteLine($"{input} is floating point type");
            }
            else if (input.Length == 1)
            {
                Console.WriteLine($"{input} is character type");
            }
            else if (isBoolean)
            {
                Console.WriteLine($"{input} is boolean type");
            }
            else
            {
                Console.WriteLine($"{input} is string type");
            }

            input = Console.ReadLine();
        }
    }
}