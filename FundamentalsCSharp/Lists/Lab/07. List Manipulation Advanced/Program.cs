internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> originalList = new List<int>();

        foreach (var item in list)
        {
            originalList.Add(item);
        }

        string command;
        int sum = 0;

        while ((command = Console.ReadLine()) != "end")
        {
            string realcommand = command.Split()[0];

            if (realcommand == "Add")
            {
                int number = int.Parse(command.Split()[1]);
                list.Add(number);
            }
            else if (realcommand == "Remove")
            {
                int number = int.Parse((command.Split()[1]));
                list.Remove(number);
            }
            else if (realcommand == "RemoveAt")
            {
                int index = int.Parse((command.Split()[1]));
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == index)
                    {
                        list.RemoveAt(i);
                    }
                }
            }
            else if (realcommand == "Insert")
            {
                int number = int.Parse((command).Split()[1]);
                int index = int.Parse((command).Split()[2]);
                list.Insert(index, number);
            }
            else if (realcommand == "Contains")
            {
                int number = int.Parse(command.Split()[1]);
                if (list.Contains(number))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No such number");
                }
            }
            else if (realcommand == "PrintEven")
            {
                var evenNumbers = list.Where(item => item % 2 == 0);
                Console.WriteLine(string.Join(" ", evenNumbers));
            }
            else if (realcommand == "PrintOdd")
            {
                var oddNumbers = list.Where(item => item % 2 != 0);
                Console.WriteLine(string.Join(" ", oddNumbers));
            }
            else if (realcommand == "GetSum")
            {
                sum = list.Sum();
                Console.WriteLine(sum);
            }
            else if (realcommand == "Filter")
            {
                string actionOperator = command.Split()[1];
                int number = int.Parse(command.Split()[2]);

                switch (actionOperator)
                {
                    case "<":
                        var lessThanNumbers = list.Where(item => item < number);
                        Console.WriteLine(string.Join(" ", lessThanNumbers));
                        break;
                    case ">":
                        var greaterThanNumbers = list.Where(item => item > number);
                        Console.WriteLine(string.Join(" ", greaterThanNumbers));
                        break;
                    case "<=":
                        var lessThanOrEqualToNumbers = list.Where(item => item <= number);
                        Console.WriteLine(string.Join(" ", lessThanOrEqualToNumbers));
                        break;
                    case ">=":
                        var greaterThanOrEqualToNumbers = list.Where(item => item >= number);
                        Console.WriteLine(string.Join(" ", greaterThanOrEqualToNumbers));
                        break;
                }
            }
        }

        if (!list.SequenceEqual(originalList))
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}