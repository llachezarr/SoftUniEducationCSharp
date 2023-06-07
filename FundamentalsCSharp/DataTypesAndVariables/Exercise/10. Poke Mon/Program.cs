using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int pokePowerN = int.Parse(Console.ReadLine());
        int distanceM = int.Parse(Console.ReadLine());
        int exhaustionFactorY = int.Parse(Console.ReadLine());

        int originalPokePowerN = pokePowerN;
        int targetCount = 0;

        while (pokePowerN >= distanceM)
        {
            pokePowerN -= distanceM;
            targetCount++;

            if (pokePowerN == originalPokePowerN * 0.5m && exhaustionFactorY != 0)
            {
                pokePowerN /= exhaustionFactorY;
            }
        }

        Console.WriteLine(pokePowerN);
        Console.WriteLine(targetCount);
    }
}