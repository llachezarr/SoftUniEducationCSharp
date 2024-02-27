List<int> input = Console
    .ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

Stack<int> stack = new Stack<int>(input);

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] splitted = command.Split(" ");

    if (command.Contains("add"))
    {
        int firstValue = int.Parse(splitted[1]);
        int secondValue = int.Parse(splitted[2]);

        stack.Push(firstValue);
        stack.Push(secondValue);
    }
    else if (command.Contains("remove"))
    {
        int n = int.Parse(splitted[1]);

        if (n <= stack.Count) {

        for (int i = 0; i < n; i++)
        {
            stack.Pop();
        }
    }
}
    command = Console.ReadLine().ToLower();
}

int sum = 0;

while (stack.Count > 0)
{
    sum += stack.Pop();
}

Console.WriteLine($"Sum: {sum}");