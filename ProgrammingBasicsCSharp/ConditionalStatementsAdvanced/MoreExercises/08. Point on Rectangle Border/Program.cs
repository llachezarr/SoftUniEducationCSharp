﻿using System;

namespace _08._Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isOnLeftOrRightSide = (x == x1 || x == x2) && y >= y1 && y <= y2;
            bool isOnTopOrBottomSide = (y == y1 || y == y2) && x >= x1 && x <= x2;

            if (isOnLeftOrRightSide || isOnTopOrBottomSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
