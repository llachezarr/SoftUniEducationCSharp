
using System.Text.RegularExpressions;

class Follower
{
    public string Username { get; }
    public int Likes { get; set; }
    public int Comments { get; set; }

    public Follower(string username)
    {
        Username = username;
        Likes = 0;
        Comments = 0;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Follower> followers = new Dictionary<string, Follower>();

        string input;
        while ((input = Console.ReadLine()) != "Log out")
        {
            string[] command = input.Split(": ");
            string socialActions = command[0];
            string username = command[1];

            switch (socialActions)
            {
                case "New follower":

                    if (!followers.ContainsKey(username))
                    {

                        followers.Add(username, new Follower(username));
                    }
                    break;

                case "Like":

                    int likesCount = int.Parse(command[2]);

                    if (!followers.ContainsKey(username))
                    {

                        followers.Add(username, new Follower(username));
                    }

                    followers[username].Likes += likesCount;
                    break;

                case "Comment":

                    if (!followers.ContainsKey(username))
                    {

                        followers.Add(username, new Follower(username));
                    }

                    followers[username].Comments++;
                    break;

                case "Blocked":

                    if (followers.ContainsKey(username))
                    {

                        followers.Remove(username);
                    }
                    else
                    {

                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    break;

                default:

                    break;
            }
        }

        Console.WriteLine($"{followers.Count} followers");
        foreach (var follower in followers.Values)
        {
            Console.WriteLine($"{follower.Username}: {follower.Likes + follower.Comments}");
        }
    }
}