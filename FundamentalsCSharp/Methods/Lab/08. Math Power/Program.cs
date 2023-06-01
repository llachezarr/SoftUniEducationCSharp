using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
        double numBase = double.Parse(Console.ReadLine());
        double numPower = double.Parse(Console.ReadLine());

        PowerTheNum(numBase, numPower);
    }

    private static void PowerTheNum(double numBase, double numPower)
    {
        {
            double poweredNum = Math.Pow(numBase, numPower);

            Console.WriteLine(poweredNum);
        }
    }
}