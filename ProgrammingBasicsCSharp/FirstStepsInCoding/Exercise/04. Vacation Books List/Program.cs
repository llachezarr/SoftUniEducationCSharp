using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesCountInCurrentBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysToFinish = int.Parse(Console.ReadLine());

            int totalTime = pagesCountInCurrentBook / pagesPerHour;
            int finalTime = totalTime / daysToFinish;

            Console.WriteLine(finalTime);
        }
    }
}
