using System;

class Program
{
    static void Main(string[] args)
    {
        int daysOfAdventure = int.Parse(Console.ReadLine());
        int playerCount = int.Parse(Console.ReadLine());
        double groupEnergy = double.Parse(Console.ReadLine());
        double waterPerPerson = double.Parse(Console.ReadLine());
        double foodPerPerson = double.Parse(Console.ReadLine());

        double totalWater = waterPerPerson * playerCount * daysOfAdventure;
        double totalFood = foodPerPerson * playerCount * daysOfAdventure;
        double energyLoss;

        for (int day = 1; day <= daysOfAdventure; day++)
        {
            energyLoss = double.Parse(Console.ReadLine());
            groupEnergy -= energyLoss;

            if (groupEnergy <= 0)
            {
                Console.WriteLine(
                    $"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
                return;
            }

            if (day % 2 == 0)
            {
                double waterToDrink = totalWater * 0.30;
                groupEnergy += groupEnergy * 0.05;
                totalWater -= waterToDrink;
            }

            if (day % 3 == 0)
            {
                double foodToEat = totalFood / playerCount;
                groupEnergy += groupEnergy * 0.10;
                totalFood -= foodToEat;
            }
        }

        Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
    }
}
