string[] input = Console
    .ReadLine()
    .Split();

Stack<string> operations = 
    new Stack<string>(new Stack<string>(input));


while (operations.Count > 1)
{
    int firstValue = int.Parse(operations.Pop());
    string operatorSign = operations.Pop();
    int secondValue = int.Parse(operations.Pop());

    if (operatorSign == "+")
    {
        operations.Push((firstValue + secondValue).ToString());
    }
    if (operatorSign == "-")
    {
        operations.Push((firstValue - secondValue).ToString());
    }
}

Console.WriteLine(operations.Pop());