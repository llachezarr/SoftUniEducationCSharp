using System;

namespace _08._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int prevSum = 0;
            int maxDiff = 0;
            bool allEqual = true;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int sum = num1 + num2;

                if (i > 0)
                {
                    int diff = Math.Abs(sum - prevSum);

                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }

                    if (diff != 0)
                    {
                        allEqual = false;
                    }
                }

                prevSum = sum;
            }

            if (allEqual)
            {
                Console.WriteLine($"Yes, value={prevSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
