using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int playingNorm = 30000;

            int dayOffs = int.Parse(Console.ReadLine());

            int workingDays = 365 - dayOffs;

            int dayOffsPlayTime = dayOffs * 127;
            int playTimeWorkingDays = workingDays * 63;
            int playTimeTotal = dayOffsPlayTime + playTimeWorkingDays;

            int difference = playingNorm - playTimeTotal;

            int hours = Math.Abs(difference / 60);
            int minutes = Math.Abs(difference % 60);

            if (playTimeTotal < playingNorm)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            } else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }

        }
    }
}
