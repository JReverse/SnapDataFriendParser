// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using SnapDataFriendParser.Classes;

FriendKlass FriendKlass = JsonConvert.DeserializeObject<FriendKlass>(File.ReadAllText("friends.json")) ?? throw new Exception("File Cant Be Empty"); 

foreach (Friend Username in FriendKlass.Friends)
{
    using (var stream = new StreamWriter("Friends.txt", true))
    {
        stream.WriteLine(Username.Username);
    }
}

foreach (BlockedUser Username in FriendKlass.BlockedUsers)
{
    using (var stream = new StreamWriter("Blocked.txt", true))
    {
        stream.WriteLine(Username.Username);
    }
}

Console.WriteLine("Done!");
Console.ReadLine();