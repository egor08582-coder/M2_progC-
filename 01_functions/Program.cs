namespace _01_functions;

class Program
{
    static void Main(string[] args)
    {
        Program app = new Program(); // nieuwe variabele: app, type: Program (object van de class Program)
        app.Run(); // roept de functie Run() aan
    }

    void Run()
    {
        Console.WriteLine("Hello World!");// toont de tekst "Hello World!" in de terminal
    }
}
