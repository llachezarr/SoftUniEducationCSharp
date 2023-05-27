using System;

namespace _06._Rhombus_of_Stars
{

    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());

                // Горна част на ромба
                for (int row = 1; row <= n; row++)
                {
                    for (int i = 1; i <= n - row; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("*");

                    for (int i = 1; i < row; i++)
                    {
                        Console.Write(" *");
                    }

                    Console.WriteLine();
                }

                // Долна част на ромба
                for (int row = n - 1; row >= 1; row--)
                {
                    for (int i = 1; i <= n - row; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("*");

                    for (int i = 1; i < row; i++)
                    {
                        Console.Write(" *");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}