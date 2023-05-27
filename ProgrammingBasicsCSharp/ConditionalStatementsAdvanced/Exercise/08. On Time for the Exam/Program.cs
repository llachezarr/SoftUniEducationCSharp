using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;

            if (arrivalTime > examTime)
            {
                Console.WriteLine("Late");

                int minutesLate = arrivalTime - examTime;
                if (minutesLate >= 60)
                {
                    int hoursLate = minutesLate / 60;
                    int minutesRemaining = minutesLate % 60;
                    Console.WriteLine("{0}:{1:D2} hours after the start", hoursLate, minutesRemaining);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", minutesLate);
                }
            }
            else if (arrivalTime == examTime || examTime - arrivalTime <= 30)
            {
                Console.WriteLine("On time");

                int minutesBeforeStart = examTime - arrivalTime;
                if (minutesBeforeStart != 0)
                {
                    Console.WriteLine("{0} minutes before the start", minutesBeforeStart);
                }
            }
            else if (examTime - arrivalTime > 30)
            {
                Console.WriteLine("Early");

                int minutesEarly = examTime - arrivalTime;
                if (minutesEarly >= 60)
                {
                    int hoursEarly = minutesEarly / 60;
                    int minutesRemaining = minutesEarly % 60;
                    Console.WriteLine("{0}:{1:D2} hours before the start", hoursEarly, minutesRemaining);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", minutesEarly);
                }
            }
        }
    }
}
