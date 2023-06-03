internal class Program
{
    private static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        int sum = Add(firstNum, secondNum);
        int totalSum = Subt(thirdNum, sum);

        Console.WriteLine(totalSum);
    }
    private static int Add(int firstNum, int secondNum)
    {
        int sum = firstNum + secondNum;
        return sum;
    }

    private static int Subt(int thirdNum, int sum)
    {
        int totalSum = sum - thirdNum;
        return totalSum;
    }
}