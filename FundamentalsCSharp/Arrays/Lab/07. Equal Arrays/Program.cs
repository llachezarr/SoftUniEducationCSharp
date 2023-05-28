using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr1 = Console
                    .ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

        int[] arr2 = Console
                    .ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
        int sum = 0;
        bool isEqual = false;
        int counter = 0;

        for (int i = 0; i < arr1.Length; i++)
        {

            if (arr1[i] != arr2[i])
            {
                isEqual = false;
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                break;
            }
            else
            {
                sum += arr1[i];
                isEqual = true;
            }

            /*for (int j = 0; j < arr2.Length; j++)
            {

                
                if (arr1[i] != arr2[j])
                {
                    isEqual = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    sum += arr1[i];
                    isEqual = true;
                }
            } */
        }

        if (isEqual) 
        {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }

    }
}