internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Done")
                break;

            string[] tokens = command.Split();
            string commandWord = tokens[0];

            switch (commandWord)
            {
                case "Change":

                    char lettersToReplace = tokens[1][0];
                    char replaceWith = tokens[2][0];

                    input = input.Replace(lettersToReplace, replaceWith);
                    Console.WriteLine(input);
                    break;

                case "Includes":

                    string substringToCheck = command.Substring(commandWord.Length + 1);
                    bool includesSubstring = input.Contains(substringToCheck);

                    Console.WriteLine(includesSubstring);
                    break;

                case "End":

                    string endSubstring = command.Substring(commandWord.Length + 1);
                    bool endsWithSubstring = input.EndsWith(endSubstring);

                    Console.WriteLine(endsWithSubstring);
                    break;

                case "Uppercase":

                    input = input.ToUpper();
                    Console.WriteLine(input);
                    break;

                case "FindIndex":

                    char charToFind = tokens[1][0];
                    int index = input.IndexOf(charToFind);

                    Console.WriteLine(index);
                    break;

                case "Cut":

                    int beggining = int.Parse(tokens[1]);
                    int count = int.Parse(tokens[2]);
                    string cutChars = input.Substring(beggining, count);

                    Console.WriteLine(cutChars);
                    break;

                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }
}