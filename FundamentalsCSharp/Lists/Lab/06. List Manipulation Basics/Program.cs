
using System.Windows.Markup;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        string command;
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
        }
        Console.WriteLine(string.Join(" ", list));
    }
}