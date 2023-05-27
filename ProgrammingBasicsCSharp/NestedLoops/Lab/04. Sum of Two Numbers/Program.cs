using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalStop = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            int i, j;
            bool valid = false;

            for (i = intervalStart; i <= intervalStop; i++)
            {
                for (j = intervalStart; j <= intervalStop; j++)
                {
                    counter++;

                    if (i + j == magicalNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {i + j})");
                        valid = true;
                        break;
                    }
                }

                if (valid)
                {
                    break;
                }
            }

            if (valid != true)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }


        }
    }
}