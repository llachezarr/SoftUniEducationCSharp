using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double academyScore = double.Parse(Console.ReadLine());
            int countJuryTotal = int.Parse(Console.ReadLine());
            string nameJury;
            double juryScore = 0;
            double calculatedScore = 0;

            for (int i = 0; i < countJuryTotal; i++)
            {
                nameJury = Console.ReadLine();
                juryScore = double.Parse(Console.ReadLine());

                calculatedScore += ((juryScore * nameJury.Length) / 2);

                if (calculatedScore + academyScore > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {calculatedScore + academyScore:F1}!");
                    break;
                }
            }

            if (calculatedScore + academyScore < 1250.5)
            {
                double neededScore = 1250.5 - (calculatedScore + academyScore);

                Console.WriteLine($"Sorry, {nameActor} you need {neededScore:F1} more!");
            }
        }
    }
}
