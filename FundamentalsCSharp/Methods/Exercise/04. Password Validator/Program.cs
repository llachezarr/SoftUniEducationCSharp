using System;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string password = Console.ReadLine();

        bool isValid = IsPasswordValid(password);

        if (isValid)
        {
            Console.WriteLine("Password is valid");
        }
    }

    private static bool IsPasswordValid(string password)
    {
        bool isValid = true;

        if (password.Length < 6 || password.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            isValid = false;
        }

        if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
        {
            Console.WriteLine("Password must consist only of letters and digits");
            isValid = false;
        }

        int digitCount = 0;
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }

        if (digitCount < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            isValid = false;
        }

        return isValid;
    }
}