internal class Program
{
    private static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        string[] days = {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        if (input < 1 || input > 7)
        {
            Console.WriteLine("Invalid day!");
           
        }
        else
        {
            Console.WriteLine(days[input - 1]);
        }
    }
}