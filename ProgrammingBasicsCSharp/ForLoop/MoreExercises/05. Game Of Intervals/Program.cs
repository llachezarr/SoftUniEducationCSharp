using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
{

    static void Main(string[] args)
    {
        int entersCount = int.Parse(Console.ReadLine());

        double zeroNine = 0;
        double tenNineteen = 0;
        double twentyTwentynine = 0;
        double thertyThertynine = 0;
        double fortyFifty = 0;
        double invalidNumber = 0;
        double totalPoint = 0;


        for (int i = 0; i < entersCount; i++)
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= 0 && number <= 9)
            {
                zeroNine++;
                totalPoint += (0.2 * number);
            }
            if (number >= 10 && number <= 19)
            {
                tenNineteen++;
                totalPoint += (0.3 * number);
            }
            if (number >= 20 && number <= 29)
            {
                twentyTwentynine++;
                totalPoint += (0.4 * number);
            }
            if (number >= 30 && number <= 39)
            {
                thertyThertynine++;
                totalPoint += 50;
            }
            if (number >= 40 && number <= 50)
            {
                fortyFifty++;
                totalPoint += 100;
            }
            if (number < 0 || number > 50)
            {
                invalidNumber++;
                totalPoint = totalPoint / 2;
            }
        }

        Console.WriteLine($"{totalPoint:f2}");
        Console.WriteLine($"From 0 to 9: {(zeroNine * 100 / entersCount):f2}%");
        Console.WriteLine($"From 10 to 19: {(tenNineteen * 100 / entersCount):f2}%");
        Console.WriteLine($"From 20 to 29: {(twentyTwentynine * 100 / entersCount):f2}%");
        Console.WriteLine($"From 30 to 39: {(thertyThertynine * 100 / entersCount):f2}%");
        Console.WriteLine($"From 40 to 50: {(fortyFifty * 100 / entersCount):f2}%");
        Console.WriteLine($"Invalid numbers: {(invalidNumber * 100 / entersCount):f2}%");
    }
}
}