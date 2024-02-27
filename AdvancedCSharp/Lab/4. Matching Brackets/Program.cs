string input = Console.ReadLine();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        stack.Push(i);
    }
    else if (input[i] == ')')
    {
        if (stack.Count == 0)
        {
            return;
        }

        int openingIndex = stack.Pop();

        string subExpression = input.Substring
            (openingIndex, i - openingIndex + 1);
        Console.WriteLine(subExpression);
    }
}
