using System;

namespace _07._House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWall = x * y;
            double window = 1.5 * 1.5;
            double sideWalls = sideWall * 2 - window * 2;

            double backWall = x * x;
            double door = 1.2 * 2;
            double frontAndBackWalls = backWall * 2 - door;

            double wallsTotal = sideWalls + frontAndBackWalls;

            double roofSide = x * y;
            double roofFront = x * h / 2;
            double roofTotal = roofSide * 2 + roofFront * 2;

            double greenPaintLiters = wallsTotal / 3.4;
            double redPaintLiters = roofTotal / 4.3;

            Console.WriteLine($"{greenPaintLiters:F2}");
            Console.WriteLine($"{redPaintLiters:F2}");
        }
    }
}
