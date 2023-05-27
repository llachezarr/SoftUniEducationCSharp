using System;
using System.Diagnostics.Tracing;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
        
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int l = 0; l <= n; l++)
                    {     
                        if (i + j + l == n)
                        {
                            counter++;
                            break;
                        }
                    }
                }
            }
                Console.WriteLine(counter);
        }
    }
}
