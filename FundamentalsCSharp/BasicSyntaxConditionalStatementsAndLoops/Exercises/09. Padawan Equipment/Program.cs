internal class Program
{
    private static void Main(string[] args)
    {

        double moneyBalance = double.Parse(Console.ReadLine());
        int countStudent = int.Parse(Console.ReadLine());
        double lightSwordprice = double.Parse(Console.ReadLine());
        double priceRobe = double.Parse(Console.ReadLine());
        double priceBelt = double.Parse(Console.ReadLine());

        double lightSwordsPrice = Math.Ceiling(countStudent + 0.1 * countStudent) * lightSwordprice;
        double totalRobesPrice = countStudent * priceRobe;
        double totalBeltPrice = countStudent * priceBelt;

        int freeBelt = (countStudent / 6);

        double finalPrice = lightSwordsPrice + totalRobesPrice + (totalBeltPrice - (freeBelt * priceBelt));

        if (moneyBalance >= finalPrice)
        {
            Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
        }
        else
        {
            double neededMoney = finalPrice - moneyBalance;
            Console.WriteLine($"John will need {neededMoney:f2}lv more.");
        }

    }
}
