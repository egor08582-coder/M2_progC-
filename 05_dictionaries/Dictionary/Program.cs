class Program
{
    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    void Run()
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        personeelOpNummer.Add(382942, "jim");
        personeelOpNummer.Add(789432, "tim");

        string jim = personeelOpNummer[382942];
        string tim = personeelOpNummer[789432];

        Console.WriteLine(jim);
        Console.WriteLine(tim);

        Console.WriteLine();

        foreach (KeyValuePair<int, string> item in personeelOpNummer)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        Console.WriteLine();

        foreach (int key in personeelOpNummer.Keys)
        {
            Console.WriteLine($"key: {key}");
        }

        Console.WriteLine();

        foreach (string value in personeelOpNummer.Values)
        {
            Console.WriteLine($"value: {value}");
        }
    }
}
