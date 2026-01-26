static void Main(string[] args)
{
    Program app = new Program();
    app.Run();
}

private void Run()
{
    Quiz quiz = new Quiz(10);
    QuizVraag quizVraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
}

class QuizVraagAntwoord
{
    internal QuizVraag vraag;
    internal bool goed;

    internal QuizVraagAntwoord(QuizVraag vraag)
    {
        this.vraag = vraag;
        goed = false;
    }
}

class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
        ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
    }
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