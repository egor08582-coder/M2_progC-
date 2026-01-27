class Program
{
    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    void Run()
    {
        double[] prijzen = new double[] { 0.99, 5.60, 10.11 };
        string[] artikelen = { "snoepje", "luxe broodje", "lunch menu" };
        Formulier[] formulieren = new Formulier[2];


        formulieren[0] = new Formulier()
        {
            Feedback = "prijzig maar lekker",
            Sterren = 5
        };

        formulieren[1] = new Formulier()
        {
            Feedback = "lunch menu was erg veel",
            Sterren = 3
        };

        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(prijzen[i]);
            Console.WriteLine(artikelen[i]);
        }


        foreach (Formulier i in formulieren)
        {
            Console.WriteLine(i.Feedback);
            Console.WriteLine(i.Sterren);
        }

    }
}

internal class Formulier
{
    internal int Sterren { get; set; }
    internal string Feedback { get; set; }
}

