namespace _01_functions;

class Program
{
 
    string[] vragen = new string[]
    {
        "What 1997 N64 video game features James Bond and is named after the 1995 film?",
        "What arcade game was called Puckman in Japan?",
        "What is your favorite game?",
        "Where are you from?"
    };

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
        Vraag6();
        // Vraag7
            string antwoord = Vraag7();
            Console.WriteLine(antwoord);

        string vraag = GetRandomVraag();
        Console.WriteLine(vraag);

        string antwoordRandom = Console.ReadLine();
        Console.WriteLine(antwoordRandom);
    }

    string GetRandomVraag()
    {
        Random rnd = new Random();
        int random = rnd.Next(vragen.Length);
        return GetVraag(random);
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

    internal void Vraag6()
    {
        Console.WriteLine("Why do round pizzas come in square boxes?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }

    string Vraag7()
    {
        Console.WriteLine("Why do round pizzas come in square boxes?(Return test)");
        string antwoord = Console.ReadLine();
        return antwoord;
    }

    string GetVraag(int vraagIndex)
    {
        return vragen[vraagIndex];
    }


}