internal class Program
{
    private static void Main(string[] args)
    {
        int lostGamesCount = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        int counterBrokenHeadset = 0;
        int counterBrokenMouse = 0;
        int counterBrokenKeyboard = 0;
        double price = 0;

        bool headsetBroken = false;
        bool mouseBroken = false;

        for (int i = 0; i < lostGamesCount; i++)
        {
            counterBrokenHeadset++;
            counterBrokenMouse++;

            if (counterBrokenHeadset == 2)
            {
                headsetBroken = true;
                counterBrokenHeadset = 0;
                price += headsetPrice;
            }
            else
            {
                headsetBroken = false;
            }

            if (counterBrokenMouse == 3)
            {
                mouseBroken = true;
                counterBrokenMouse = 0;
                price += mousePrice;
            }
            else
            {
                mouseBroken = false;
            }

            if (headsetBroken && mouseBroken)
            {
                headsetBroken = false;
                mouseBroken = false;
                counterBrokenKeyboard++;
                price += keyboardPrice;
            }

            if (counterBrokenKeyboard == 2)
            {
                counterBrokenKeyboard = 0;
                price += displayPrice;
            }
        }
        Console.WriteLine($"Rage expenses: {price:F2} lv.");
    }
}