using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacityStadion = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int sectorACounter = 0;
            int sectorBCounter = 0;
            int sectorCCounter = 0;
            int sectorGCounter = 0;

            for (int i = 1; i <= peopleCount; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        sectorACounter++;
                        break;
                    case "B":
                        sectorBCounter++;
                        break;
                    case "V":
                        sectorCCounter++;
                        break;
                    case "G":
                        sectorGCounter++;
                        break;
                }
            }

            double fansAPercent = sectorACounter * 1.0 / peopleCount * 100;
            double fansBPercent = sectorBCounter * 1.0 / peopleCount * 100;
            double fansVPercent = sectorCCounter * 1.0 / peopleCount * 100;
            double fansGPercent = sectorGCounter * 1.0 / peopleCount * 100;
            double totalFansPercent = peopleCount * 1.0 / capacityStadion * 100;

            Console.WriteLine($"{fansAPercent:F2}%\n" +
                              $"{fansBPercent:F2}%" +
                              $"\n{fansVPercent:F2}%\n" +
                              $"{fansGPercent:F2}%\n" +
                              $"{totalFansPercent:F2}%");
        }
    }
}
