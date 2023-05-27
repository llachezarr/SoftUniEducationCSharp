using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int startingPoints = int.Parse(Console.ReadLine());

                int totalPoints = startingPoints;
                int tournamentsWon = 0;

                for (int i = 0; i < n; i++)
                {
                    string tournamentResult = Console.ReadLine();

                    switch (tournamentResult)
                    {
                        case "W":
                            totalPoints += 2000;
                            tournamentsWon++;
                            break;
                        case "F":
                            totalPoints += 1200;
                            break;
                        case "SF":
                            totalPoints += 720;
                            break;
                    }
                }

                double averagePoints = Math.Floor((double)(totalPoints - startingPoints) / n);

                double percentageTournamentsWon = (double)tournamentsWon / n * 100;

                Console.WriteLine($"Final points: {totalPoints}");
                Console.WriteLine($"Average points: {averagePoints}");
                Console.WriteLine($"{percentageTournamentsWon:f2}%");
            }
    }
}
