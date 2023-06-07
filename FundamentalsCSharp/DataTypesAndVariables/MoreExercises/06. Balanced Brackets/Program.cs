using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool isBalanced = true;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            if (input == "(")
            {
                if (isBalanced)
                {
                    isBalanced = false;
                }
                else
                {
                    break;
                }
            }
            else if (input == ")")
            {
                if (!isBalanced)
                {
                    isBalanced = true;
                }
                else
                {
                    isBalanced = false;
                }
            }
        }

        if (isBalanced)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}