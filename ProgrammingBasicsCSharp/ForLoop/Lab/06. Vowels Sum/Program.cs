using System;
using System.Threading.Tasks.Sources;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int points = 0;
            int score = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                switch (letter)
                {
                    case 'a':
                        points = 1;
                        score += points;
                        break;
                    case 'e':
                        points = 2;
                        score += points;
                        break;
                    case 'i':
                        points = 3;
                        score += points;
                        break;
                    case 'o':
                        points = 4;
                        score += points;

                        break;
                    case 'u':
                        points = 5;
                        score += points;
                        break;
                }  
            }
            Console.WriteLine(score);
        }
    }
}
