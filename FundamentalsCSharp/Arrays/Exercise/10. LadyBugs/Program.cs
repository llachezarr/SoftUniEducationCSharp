using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int fieldSize = int.Parse(Console.ReadLine());
        List<int> ladybugIndexes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> field = new List<int>();
        for (int i = 0; i < fieldSize; i++)
        {
            if (ladybugIndexes.Contains(i))
                field.Add(1);
            else
                field.Add(0);
        }

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] commandParts = command.Split();
            int ladybugIndex = int.Parse(commandParts[0]);
            string direction = commandParts[1];
            int flyLength = int.Parse(commandParts[2]);

            if (ladybugIndex >= 0 && ladybugIndex < fieldSize && field[ladybugIndex] == 1)
            {
                field[ladybugIndex] = 0; // Remove ladybug from current position

                int newPosition = ladybugIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        newPosition += flyLength;
                    }
                    else if (direction == "left")
                    {
                        newPosition -= flyLength;
                    }

                    if (newPosition < 0 || newPosition >= fieldSize)
                    {
                        // Ladybug has flown out of the field
                        break;
                    }

                    if (field[newPosition] == 0)
                    {
                        // Ladybug has found an empty spot
                        field[newPosition] = 1;
                        break;
                    }
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }
}