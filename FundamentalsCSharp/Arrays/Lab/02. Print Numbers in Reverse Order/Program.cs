internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i <numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());   
        }

        Array.Reverse(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}