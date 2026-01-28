class Program
{
    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    void Run()
    {
        Console.WriteLine(Environment.CurrentDirectory);

        string[] lines = File.ReadAllLines("quiz.txt");

        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}
