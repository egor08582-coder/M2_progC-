class Program
{
    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
        app.RunProducten();
        app.RunEigen();
    }

    Console.WriteLine();
    void Run()
    {
        string text = File.ReadAllText("Product.json");

        Product product = JsonSerializer.Deserialize<Product>(text);

        Console.WriteLine(product.Name);
        Console.WriteLine(product.Description);
        Console.WriteLine(product.Price);
    }

    Console.WriteLine();
    void RunProducten()
    {
        string text = File.ReadAllText("Producten.json");

        Product[] producten = JsonSerializer.Deserialize<Product[]>(text);

        foreach (Product p in producten)
        {
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Description);
            Console.WriteLine(p.Price);
        }
    }

    Console.WriteLine();
    void RunEigen()
    {
        string text = File.ReadAllText("Players.json");

        Player[] players = JsonSerializer.Deserialize<Player[]>(text);

        foreach (Player p in players)
        {
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Level);
            Console.WriteLine(p.Hp);
        }
    }
}

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}


public class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Hp { get; set; }
}
