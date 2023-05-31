using System;

class Program
{
        private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] elements = input.Split();

        int rotations = int.Parse(Console.ReadLine());

        RotateArray(elements, rotations);

        Console.WriteLine(string.Join(" ", elements));
    }

    static void RotateArray(string[] arr, int rotations)
    {
        for (int i = 0; i < rotations; i++)
        {
            string firstElement = arr[0];

            for (int j = 0; j < arr.Length - 1; j++)
            {
                arr[j] = arr[j + 1];
            }

            arr[arr.Length - 1] = firstElement;
        }
    }
}