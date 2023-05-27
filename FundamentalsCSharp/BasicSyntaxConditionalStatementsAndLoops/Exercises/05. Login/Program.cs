using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)
    {
        string username = Console.ReadLine();

        char[] stringArray = username.ToCharArray();
        Array.Reverse(stringArray);
        string password = new string(stringArray);

        string input = "";
        int counter = 0;

        while (input != password && counter < 4)
        {
            input = Console.ReadLine();

            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                counter++;

                if (counter < 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            if (counter == 4)
            {
                Console.WriteLine($"User {username} blocked!");
                break;
            }
        }
    }
}