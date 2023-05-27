using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double lenghtInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

            double participantTime = lenghtInMeters * timeInSecondsForOneMeter;
            double slowingCount = (Math.Floor(lenghtInMeters / 15)) * 12.5;
            double totalTime = participantTime + slowingCount;

            if (totalTime >= worldRecord)
            {
                double neededSeconds = totalTime - worldRecord;
                Console.WriteLine($"No, he failed! He was {neededSeconds:F2} seconds slower.");
            } else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
        }
    }
}
