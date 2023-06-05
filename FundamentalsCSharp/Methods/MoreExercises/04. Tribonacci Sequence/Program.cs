public class Program
{
    static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        int num3 = 1;

        int input = int.Parse(Console.ReadLine());
        if (input > 0)
        {
            Console.Write(1 + " ");
        }
        for (int i = input; i > 1; --i)
        {
            int num = num1 + num2 + num3;

            num1 = num2;
            num2 = num3;
            num3 = num;

            Console.Write(num + " ");

        }
    }
}