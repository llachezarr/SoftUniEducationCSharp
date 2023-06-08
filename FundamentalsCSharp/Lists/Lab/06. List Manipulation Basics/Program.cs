/*
4 19 2 53 6 43
Add 3
Remove 2
RemoveAt 1
Insert 8 3
end


23 1 456 63 32
87 9 32
Remove 5
Add 1
Insert 14 2
RemoveAt 3
Add 34
end
*/
using System.Windows.Markup;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> input = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string command = " ";

        while (command != "end")
        {
            command = Console.ReadLine();

            if (command == "end")
            {
                Console.WriteLine(String.Join(" ", input));
                break;
            }

            string[] commandValue = command.Split(" ");

            List<int> values = new List<int>();

            foreach (string valueString in commandValue)
            {
                int value;

                if (int.TryParse(valueString, out value))
                {
                    values.Add(value);
                }
            }

            if (command.Contains("Add"))
            {
                input.Add(values[0]);
            }
            if (command.Contains("Remove"))
            {
                input.Remove(values[0]);
            }
            if (command.Contains("RemoveAt"))
            {
                input.RemoveAt(values[0]);
            }
            if (command.Contains("Insert"))
            {
                input.Insert(values[1], values[0]);
            }
        }
    }
}