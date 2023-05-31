using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] arr1 = Console.ReadLine().Split();
        string[] arr2 = Console.ReadLine().Split();

        string common = "";

        foreach (var element2 in arr2)
        {
            foreach (var element1 in arr1)
            {
                if (element2.Equals(element1))
                {
                    common = element2;
                    Console.Write(element2 + " ");
                }
            }
        }
    }
}