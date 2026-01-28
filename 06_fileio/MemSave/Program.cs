class Program
{
    string welkomstTekst = "Hello World!";
    string saveFile = "welkomState.txt";

    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    void Run()
    {
        if (File.Exists(saveFile))
        {
            welkomstTekst = File.ReadAllText(saveFile);
        }

        while (true)
        {
            Console.WriteLine(welkomstTekst);
            Console.WriteLine("Enter a text, then press enter");

            welkomstTekst = Console.ReadLine();

            if (welkomstTekst.Length > 0)
            {
                File.WriteAllText(saveFile, welkomstTekst);
            }
        }
    }
}
