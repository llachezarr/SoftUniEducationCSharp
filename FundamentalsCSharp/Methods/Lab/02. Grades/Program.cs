internal class Program
{
    private static void Main(string[] args)
    {
        double grade = double.Parse(Console.ReadLine());

        GradesDefinition(grade);
    }

    private static double GradesDefinition(double grade)
    {
        if (grade is >= 2.0 and <= 2.99)
        {
            Console.WriteLine("Fail");
        }
        else if (grade is >= 3.0 and <= 3.49)
        {
            Console.WriteLine("Poor");
        }
        else if (grade is >= 3.50 and <= 4.49)
        {
            Console.WriteLine("Good");
        }
        else if (grade is >= 4.50 and <= 5.49)
        {
            Console.WriteLine("Very good");
        }
        else if (grade is >= 5.50 and <= 6.0)
        {
            Console.WriteLine("Excellent");
        }

        return grade;
    }
}