using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = 0;
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "square":
                    double x = double.Parse(Console.ReadLine());
                    area = x * x;
                    break;
                case "rectangle":
                    double lenght = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    area = lenght * width;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double heigh = double.Parse(Console.ReadLine());
                    area = side * heigh / 2;
                    break;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
