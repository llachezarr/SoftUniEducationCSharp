using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalSteps = 0;

            while (totalSteps < 10000)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsToHome;
                    break;
                }

                int steps = int.Parse(input);
                totalSteps += steps;
            }

            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
