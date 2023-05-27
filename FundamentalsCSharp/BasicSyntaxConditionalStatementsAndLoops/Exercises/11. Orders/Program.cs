internal class Program
{
    private static void Main(string[] args)
    {

        int orders = int.Parse(Console.ReadLine());
        double price = 0;
        double totalPrice = 0;
        double pricePerCapsule = 0;
        int days = 0;
        int countCapsules = 0;

        for (int i = 0; i < orders; i++)
        {
            pricePerCapsule = double.Parse(Console.ReadLine());
            days = int.Parse(Console.ReadLine());
            countCapsules = int.Parse(Console.ReadLine());

            price = (days * countCapsules) * pricePerCapsule;

            Console.WriteLine($"The price for the coffee is: ${price:F2}");
            totalPrice += price;
        }
        Console.WriteLine($"Total: ${totalPrice:F2}");
    }
}