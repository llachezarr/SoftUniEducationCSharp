using System;

internal class Program
{
    static void Main(string[] args)
    {
        int x1, y1, x2, y2;

        if (int.TryParse(Console.ReadLine(), out x1) && int.TryParse(Console.ReadLine(), out y1)
           && int.TryParse(Console.ReadLine(), out x2) && int.TryParse(Console.ReadLine(), out y2))
        {
            string closestPoint = GetClosestPoint(x1, y1, x2, y2);
            Console.WriteLine(closestPoint);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    static string GetClosestPoint(int x1, int y1, int x2, int y2)
    {
        double distance1 = CalculateDistanceToOrigin(x1, y1);
        double distance2 = CalculateDistanceToOrigin(x2, y2);

        if (distance1 <= distance2)
        {
            return $"({x1}, {y1})";
        }
        else
        {
            return $"({x2}, {y2})";
        }
    }

    static double CalculateDistanceToOrigin(int x, int y)
    {
        double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        return distance;
    }
}