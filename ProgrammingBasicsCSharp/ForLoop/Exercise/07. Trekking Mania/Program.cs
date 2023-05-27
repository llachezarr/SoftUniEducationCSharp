using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());

            int groupPeopleCount = 0;
            int totalPeople = 0;
            int musaCount = 0;
            int monCount = 0;
            int kilimCount = 0;
            int k2Count = 0;
            int everCount = 0;

            for (int i = 0; i < groupCount; i++)
            {
                groupPeopleCount = int.Parse(Console.ReadLine());

                totalPeople += groupPeopleCount;

                if (groupPeopleCount <= 5)
                {
                    // musala
                    musaCount += groupPeopleCount;
                }
                else if (groupPeopleCount <= 12)
                {
                    // Monblan
                    monCount += groupPeopleCount;
                }
                else if (groupPeopleCount <= 25)
                {
                    // Kilimanjaro
                    kilimCount += groupPeopleCount;
                }
                else if (groupPeopleCount <= 40)
                {
                    // K2
                    k2Count += groupPeopleCount;
                }
                else
                {
                    // Everest
                    everCount += groupPeopleCount;
                }
            }

            double percentMusa = (double)musaCount / totalPeople * 100;
            double percentMon = (double)monCount / totalPeople * 100;
            double percentKilim = (double)kilimCount / totalPeople * 100;
            double percentK2 = (double)k2Count / totalPeople * 100;
            double percentEver = (double)everCount / totalPeople * 100;

            Console.WriteLine($"{percentMusa:F2}%");
            Console.WriteLine($"{percentMon:F2}%");
            Console.WriteLine($"{percentKilim:F2}%");
            Console.WriteLine($"{percentK2:F2}%");
            Console.WriteLine($"{percentEver:F2}%");
        }
    }
}
