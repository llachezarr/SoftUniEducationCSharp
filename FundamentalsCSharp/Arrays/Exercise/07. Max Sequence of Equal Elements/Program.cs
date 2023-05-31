using System;
using System.Linq;

class Program
{
    private static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int longestSequenceStartIndex = 0;
        int longestSequenceLength = 1;

        int currentSequenceStartIndex = 0;
        int currentSequenceLength = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                currentSequenceLength++;

                if (currentSequenceLength > longestSequenceLength)
                {
                    longestSequenceLength = currentSequenceLength;
                    longestSequenceStartIndex = currentSequenceStartIndex;
                }
            }
            else
            {
                currentSequenceStartIndex = i;
                currentSequenceLength = 1;
            }
        }

        int[] longestSequence = new int[longestSequenceLength];
        Array.Copy(input, longestSequenceStartIndex, longestSequence, 0, longestSequenceLength);
        Console.WriteLine(string.Join(" ", longestSequence));
    }
}