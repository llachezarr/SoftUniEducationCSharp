using System;

namespace _06._Bills
{
    internal class Program
    {
            static void Main(string[] args)
        {
            int monthsCount = int.Parse(Console.ReadLine());

            double internetBill = 15;
            double waterBill = 20;
            double otherBills = 0;

            double internetBillCount = 0;
            double waterBillCount = 0;
            double electricityBillCount = 0;
            double otherBillsCount = 0;

            for (int i = 0; i < monthsCount; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());

                electricityBillCount += electricityBill;
                waterBillCount += waterBill;
                internetBillCount += internetBill;
                otherBills = (electricityBill + waterBill + internetBill) * 1.2;
                otherBillsCount += otherBills;
            }

            double average = (electricityBillCount + waterBillCount + internetBillCount + otherBillsCount) / monthsCount;

            Console.WriteLine($"Electricity: {electricityBillCount:F2} lv");
            Console.WriteLine($"Water: {waterBillCount:F2} lv");
            Console.WriteLine($"Internet: {internetBillCount:F2} lv");
            Console.WriteLine($"Other: {otherBillsCount:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
