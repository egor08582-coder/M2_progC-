static void Main(string[] args)
{
    Program app = new Program();
    app.Run();
}

private void Run()
{
    QuizVraag quizVraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
}

class QuizVraagAntwoord
{
    internal QuizVraag vraag;
    internal bool goed;
}

class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;
}

class QuizVraag
{
    internal string vraag;
    internal string antwoord;

    internal QuizVraag(string vraag, string antwoord)
    {
        this.vraag = vraag;
        this.antwoord = antwoord;
    }
}