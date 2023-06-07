internal class Program
{
    private static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());
        int decryptedChar = ' ';
        List<char> message = new List<char>();

        for (int i = 0; i < count; i++)
        {
            char input = Console.ReadLine()[0];
            
            decryptedChar = (int)input + key;
            message.Add((char)decryptedChar);
        }

        Console.WriteLine(String.Join("", message));
    }
}