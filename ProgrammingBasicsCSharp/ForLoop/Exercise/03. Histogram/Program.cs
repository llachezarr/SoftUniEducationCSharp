using System;

class Histogram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
        for (int i = 0; i < n; i++)
        {
            int number = numbers[i];
            if (number < 200)
            {
                p1++;
            }
            else if (number < 400)
            {
                p2++;
            }
            else if (number < 600)
            {
                p3++;
            }
            else if (number < 800)
            {
                p4++;
            }
            else
            {
                p5++;
            }
        }

        Console.WriteLine("{0:F2}%", p1 * 100.0 / n);
        Console.WriteLine("{0:F2}%", p2 * 100.0 / n);
        Console.WriteLine("{0:F2}%", p3 * 100.0 / n);
        Console.WriteLine("{0:F2}%", p4 * 100.0 / n);
        Console.WriteLine("{0:F2}%", p5 * 100.0 / n);
    }
}
