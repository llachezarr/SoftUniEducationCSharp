using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        string dataType = Console.ReadLine();
        string value1 = Console.ReadLine();
        string value2 = Console.ReadLine();

        switch (dataType)
        {
            case "int":
                GetMaxInt(int.Parse(value1), int.Parse(value2));
                break;
            case "char":
                GetMaxChar(value1[0], value2[0]);
                break;
            case "string":
                GetMaxString(value1, value2);
                break;
        }

    }

    private static int GetMaxInt(int num1, int num2)
    {
        if (num1 > num2)
        {
            Console.WriteLine(num1);
        }
        else
        {
            Console.WriteLine(num2);
        }

        return num1;
    }

    private static char GetMaxChar(char num1, char num2)
    {
        if (num1 > num2)
        {
            Console.WriteLine(num1);
        }
        else
        {
            Console.WriteLine(num2);
        }

        return num1;
    }
    private static string GetMaxString(string num1, string num2)
    {
        if (num1.Equals(num2))
        {
            Console.WriteLine(num1);
        }
        else
        {
            Console.WriteLine(num2);
        }

        return num1;
    }
}