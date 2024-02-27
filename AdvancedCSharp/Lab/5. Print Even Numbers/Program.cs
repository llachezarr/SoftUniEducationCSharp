using System.Collections.Generic;

int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>(input);

bool first = true;

while (queue.Count > 0)
{
    int current = queue.Dequeue();

    if (current % 2 != 0)
    {
        continue;
    }

    if (!first)
    {
        Console.Write(", ");
    }

    Console.Write(current);
    first = false;
}