internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Length: ");
        double lenght = double.Parse(Console.ReadLine());

        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        double heigth = double.Parse(Console.ReadLine());


        double volume = ((lenght * width ) / 3) * heigth;

        Console.Write($"Pyramid Volume: {volume:f2}");
    }
}