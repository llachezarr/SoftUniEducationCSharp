using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] cars = input.Split(">>");

        double totalTaxCollected = 0;
        double initialTax = 0;
        double tax = 0;

        foreach (string parameter in cars)
        {
            string[] carParameters = parameter.Split();
            string carType = carParameters[0];
            int years = int.Parse(carParameters[1]);
            int kilometers = int.Parse(carParameters[2]);


            switch (carType)
            {
                case "family":
                    initialTax = 50;
                    tax = initialTax - (5 * years) + (12 * (kilometers / 3000));
                    break;
                case "heavyDuty":
                    initialTax = 80;
                    tax = initialTax - (8 * years) + (14 * (kilometers / 9000));
                    break;
                case "sports":
                    initialTax = 100;
                    tax = initialTax - (9 * years) + (18 * (kilometers / 2000));
                    break;
                default:
                    Console.WriteLine("Invalid car type.");
                    continue;
            }

            if (tax > 0)
            {
                totalTaxCollected += tax;
                Console.WriteLine($"A {carType} car will pay {tax:F2} euros in taxes.");
            }
        }

        Console.WriteLine($"The National Revenue Agency will collect {totalTaxCollected:F2} euros in taxes.");
    }
}