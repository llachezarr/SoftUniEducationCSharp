using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double bonusScore = 0;

            if (number <= 100) {

                bonusScore += 5;
            } else if (number > 100 && number <= 1000)
            {
                bonusScore = number * 0.2;
            } else
            {
                bonusScore = number * 0.1;
            }

            if (number % 2 == 0)
            {
                bonusScore++;
            } else if (number % 5 == 0)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(number+bonusScore);
        }
    }
}
