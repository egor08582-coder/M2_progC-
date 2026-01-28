using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    void Run()
    {
        File.WriteAllText("mijntekst.txt", "Dit is mijn eerste tekst");

        string[] regels =
        {
            "Stille nacht",
            "Code stroomt als een rivier",
            "Bug vrij vandaag"
        };

        File.WriteAllLines("mijnregels.txt", regels);

        FavoriteGame[] favoriteGames =
        {
            new FavoriteGame { Name = "Super Metroid", Platform = "SNES" },
            new FavoriteGame { Name = "Demon's Souls", Platform = "PS5" },
            new FavoriteGame { Name = "Zelda A Link to the Past", Platform = "SNES" }
        };

        string json = JsonSerializer.Serialize(favoriteGames);
        File.WriteAllText("games.json", json);
    }
}

public class FavoriteGame
{
    public string Name { get; set; }
    public string Platform { get; set; }
}