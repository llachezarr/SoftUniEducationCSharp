using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nailonSquareMeters = int.Parse(Console.ReadLine());
            int paintInLiters = int.Parse(Console.ReadLine());
            int corselineInLiters = int.Parse(Console.ReadLine());
            int hoursToBeCompleted = int.Parse(Console.ReadLine());

            double nailonPrice = (nailonSquareMeters + 2) * 1.5;
            double extraPaint = paintInLiters * 0.1;
            double paintPrice = (paintInLiters + extraPaint) * 14.5;
            double corselinePrice = corselineInLiters * 5;
            double totalPrice = nailonPrice + corselinePrice + paintPrice + 0.4; ;
            double paintersPrice = (totalPrice * 0.3) * hoursToBeCompleted;
            double finalPrice = totalPrice + paintersPrice;

            Console.WriteLine(finalPrice);
        }
    }
}
