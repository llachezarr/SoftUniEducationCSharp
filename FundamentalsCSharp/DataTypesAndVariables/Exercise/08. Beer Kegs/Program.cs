using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string biggestKegModel = "";
        double biggestKegVolume = 0;

        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;

            if (volume > biggestKegVolume)
            {
                biggestKegVolume = volume;
                biggestKegModel = model;
            }
        }

        Console.WriteLine(biggestKegModel);
    }
}