internal class Program
{
    private static void Main(string[] args)
    {
        int peopleCount = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string weekDay = Console.ReadLine();

        double price = 0;
        double totalPrice = 0;

        switch (groupType)
        {
            case "Students":
                switch (weekDay)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.80;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                }

                totalPrice = price * peopleCount;

                if (peopleCount >= 30)
                {
                    totalPrice *= 0.85;
                }
                break;

            case "Business":
                switch (weekDay)
                {
                    case "Friday":
                        price = 10.90;
                        break;
                    case "Saturday":
                        price = 15.60;
                        break;
                    case "Sunday":
                        price = 16;
                        break;
                }
                if (peopleCount >= 100)
                {
                    peopleCount -= 10;
                }

                totalPrice = price * peopleCount;
                break;

            case "Regular":
                switch (weekDay)
                {
                    case "Friday":
                        price = 15;
                        break;
                    case "Saturday":
                        price = 20;
                        break;
                    case "Sunday":
                        price = 22.50;
                        break;
                }

                totalPrice = price * peopleCount;
                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    totalPrice *= 0.95;
                }
                break;
        }

        Console.WriteLine($"Total price: {totalPrice:F2}");
    }
}