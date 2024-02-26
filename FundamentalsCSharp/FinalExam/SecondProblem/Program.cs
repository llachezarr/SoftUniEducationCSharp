using System;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        int numPasswords;

        if (int.TryParse(Console.ReadLine(), out numPasswords))
        {
            for (int i = 0; i < numPasswords; i++)
            {
                string password = Console.ReadLine();
                bool isValid = ValidatePassword(password, out string encryptedPassword);

                if (isValid)
                {
                    if (encryptedPassword != null)
                        Console.WriteLine($"Password: {encryptedPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }

    static bool ValidatePassword(string password, out string encryptedPassword)
    {
        encryptedPassword = "";
        // string pattern = @"^(?<symbols>\W*)>(?<numbers>\d{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<other>[^<>]{3})<\k<symbols>$";
        string pattern = @"^(?<symbols>[a-zA-Z0-9!@#$%^&*()_+|~=`{}\[\]:\"";'<>?,.\/\\-]+)>(?<numbers>\d{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<other>[^<>]{3})<\k<symbols>$$";

        Match match = Regex.Match(password, pattern);

        if (match.Success)
        {
            string symbols = match.Groups["symbols"].Value;
            string numbers = match.Groups["numbers"].Value;
            string lower = match.Groups["lower"].Value;
            string upper = match.Groups["upper"].Value;
            string other = match.Groups["other"].Value;

            bool hasUppercase = upper.Any(char.IsUpper);
            bool hasDigit = numbers.Any(char.IsDigit);
            bool hasSpecialCharacter = other.Any(c => !char.IsLetterOrDigit(c));

            if (hasUppercase && hasDigit && hasSpecialCharacter)
            {
                encryptedPassword = numbers + lower + upper + other;
                return true;
            }
        }

        return false;
    }
}