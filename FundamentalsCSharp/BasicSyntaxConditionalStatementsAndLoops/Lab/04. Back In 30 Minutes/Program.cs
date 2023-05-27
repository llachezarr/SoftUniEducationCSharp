internal class Program
{
    private static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int hoursToMinutes = hours * 60;
        int totalTime = hoursToMinutes + minutes + 30;

        int hoursFinal = totalTime / 60;
        int minutesFinal = totalTime % 60;

        if (hoursFinal > 23)
        {
            hoursFinal = 0;
        }

        if (minutesFinal < 10)
        {

            Console.WriteLine($"{hoursFinal}:0{minutesFinal}");
        }
        else
        {
            Console.WriteLine($"{hoursFinal}:{minutesFinal}");
        }
    }
}