namespace _01_functions;

class Program
{
    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    void Run()
    {
        Vraag1(); 
        Vraag2();
        Vraag3();
        Vraag4();
        Vraag5();   

    }

    internal void Vraag1()
    {
        Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }

        internal void Vraag2()
    {
        Console.WriteLine("What is your name?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }

        internal void Vraag3()
    {
        Console.WriteLine("How old are you?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }

        internal void Vraag4()
    {
        Console.WriteLine("Where are you from?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }

        internal void Vraag5()
    {
        Console.WriteLine("Do you see me?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }

}
