internal class Program
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());

        int[][] triangle = GeneratePascalsTriangle(rows);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(triangle[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[][] GeneratePascalsTriangle(int rows)
    {
        int[][] triangle = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;

            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }

            triangle[i][i] = 1;
        }

        return triangle;
    }
}