using System;
using System.Diagnostics.Tracing;
using static System.Reflection.Metadata.BlobBuilder;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            string desiredBook;
            int counter = 0;
            bool notFound = false;

            while ((desiredBook = Console.ReadLine()) != bookName)
            {
                counter++;

                if (desiredBook == "No More Books")
                {
                    notFound = true;
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter-1} books.");
                    break;
                }
            }

            if (!notFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
        }
    }
}
