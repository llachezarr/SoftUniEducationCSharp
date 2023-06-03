internal class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        PrintFigure(num);
    }

    private static void PrintFigure(int num)
    {
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}