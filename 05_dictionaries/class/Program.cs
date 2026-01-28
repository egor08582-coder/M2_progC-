class Program
{
    private Dictionary<string, Room> rooms = new Dictionary<string, Room>();

    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    void Run()
    {
        Room start = new Room(0, 0, new string[]
        {
            "xxxxx",
            "x...x",
            "x...x",
            "x...x",
            "xxxxx"
        });

        Room room01 = new Room(0, 1, new string[]
        {
            "xxxxx",
            "x...x",
            "xxxxx",
            "x...x",
            "xxxxx"
        });

        Room room11 = new Room(1, 1, new string[]
        {
            "xxxxx",
            "x.x.x",
            "x...x",
            "x.x.x",
            "xxxxx"
        });

        Room room10 = new Room(1, 0, new string[]
        {
            "xxxxx",
            "xx..x",
            "x...x",
            "x..xx",
            "xxxxx"
        });

        rooms.Add(start.GetRoomLocationKey(), start);
        rooms.Add(room01.GetRoomLocationKey(), room01);
        rooms.Add(room11.GetRoomLocationKey(), room11);
        rooms.Add(room10.GetRoomLocationKey(), room10);

        ShowRoom(0, 0);
        ShowRoom(0, 1);
        ShowRoom(1, 1);
        ShowRoom(1, 0);

        ShowRoom(2, 2);
    }

    private void ShowRoom(int x, int y)
    {
        string key = $"{x},{y}";

        if (!rooms.ContainsKey(key))
        {
            Console.WriteLine("Error room does not exist");
            return;
        }

        Room room = rooms[key];

        Console.WriteLine($"You are in room {x},{y}");
        foreach (string row in room.level)
        {
            Console.WriteLine(row);
        }
    }
}

class Room
{
    internal int x;
    internal int y;
    internal string[] level;

    internal Room(int x, int y, string[] level)
    {
        this.x = x;
        this.y = y;
        this.level = level;
    }

    internal string GetRoomLocationKey()
    {
        return $"{x},{y}";
    }
}
