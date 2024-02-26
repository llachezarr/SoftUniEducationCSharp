using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<string> books = Console.ReadLine().Split("&").ToList();

        bool isPossible = false;
        int index = 0;
        string command;
        while ((command = Console.ReadLine()) != "Done")
        {
            string[] commands = command.Split(" | ").ToArray();

            for (int i = 0; i < books.Count - 1; i++)
            {
                if (commands[0] == "Add Book")
                {
                    if (!books.Contains(commands[1]))
                    {
                        books.Insert(0, commands[1]);
                    }
                }
                else if (commands[0] == "Take Book")
                {
                    if (books.Contains(commands[1]))
                    {
                        books.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Insert Book")
                {
                    if (!books.Contains(commands[1]))
                    {
                        books.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Swap Books")
                {
                    if (books.Contains(commands[1]) && books.Contains(commands[2]))
                    {
                        int firstBookIndex = books.IndexOf(commands[1]);
                        int secondBookIndex = books.IndexOf(commands[2]);
                        string tempItem = books[firstBookIndex];
                        books[firstBookIndex] = books[secondBookIndex];
                        books[secondBookIndex] = tempItem;

                    }
                }
                else if (commands[0] == "Check Book")
                {
                    index = int.Parse(commands[1]);

                    if (index >= 0 && index <= books.Count)
                    {
                        isPossible = true;
                    }
                }

            }
        }

        if (isPossible)
        {
            Console.WriteLine(books[index]);
        }
        Console.WriteLine(String.Join(", ", books));
    }
}