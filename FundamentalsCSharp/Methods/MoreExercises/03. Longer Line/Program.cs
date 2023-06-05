using System;

internal class Program
{
    static void Main(string[] args)
    {
        int x1, y1, x2, y2, x3, y3, x4, y4;

        if (int.TryParse(Console.ReadLine(), out x1) && int.TryParse(Console.ReadLine(), out y1)
         && int.TryParse(Console.ReadLine(), out x2) && int.TryParse(Console.ReadLine(), out y2)
         && int.TryParse(Console.ReadLine(), out x3) && int.TryParse(Console.ReadLine(), out y3)
         && int.TryParse(Console.ReadLine(), out x4) && int.TryParse(Console.ReadLine(), out y4))
        {
            string longerLine = GetLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
            Console.WriteLine(longerLine);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    static string GetLongerLine(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
    {
        double distance1 = CalculateDistanceToOrigin(x1, y1);
        double distance2 = CalculateDistanceToOrigin(x2, y2);
        double distance3 = CalculateDistanceToOrigin(x3, y3);
        double distance4 = CalculateDistanceToOrigin(x4, y4);

        double line1Length = distance1 + distance2;
        double line2Length = distance3 + distance4;

        if (line1Length >= line2Length)
        {
            return $"({x2}, {y2})({x1}, {y1})";
        }
        else
        {
            return $"({x4}, {y4})({x3}, {y3})";
        }
    }

    static double CalculateDistanceToOrigin(int x, int y)
    {
        double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        return distance;
    }
}