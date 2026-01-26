static void Main(string[] args)
{
    Program app = new Program ();
    app.Run();
}

void Run()
{
    Auto auto1 = new Auto()
    {
        automaat = true,
        kenteken = "AA824H",
        kilometerStand = 20567,
        merk = "volkswagen"
    };

    Auto auto2 = new Auto()
    {
        automaat = false,
        kenteken = "KU786G",
        kilometerStand = 65739,
        merk = "volvo"
    };

    RijLeraar rijLeraar = new RijLeraar()
    {
        leeftijd = 30,
        naam = "John",
        zzp = false
    };

    LesUur lesUur = new LesUur()
    {
        auto = auto1,
        rijLeraar = rijLeraar,

        tijd = 1130
    };

    LesPakket pakket1 = new LesPakket()
    {
        urenGekocht = 30,
        urenVerbruikt = 10,
        examenPogingen = 0,
        automaat = true
    };

    TheorieTest theorie1 = new TheorieTest()
    {
        aantalFouten = 2,
        gehaald = false,
        afnameDatum = DateTime.Now
    };

    RijTest rijTest1 = new RijTest()
    {
        gehaald = false,
        afnameDatum = DateTime.Now
    };


    Student student1 = new Student()
    {
        naam = "Wanda",
        leeftijd = 19,
        lesPakket = pakket1,
        theorieTest = theorie1,
        rijTest = rijTest1
    };
    
    lesUur.student = student1;

}

internal class Auto
{
    internal bool automaat;
    internal string merk;
    internal string kenteken;
    internal int kilometerStand;
}

internal class RijLeraar
{
    internal string naam;
    internal int leeftijd;
    internal bool zzp;
}

internal class LesPakket
{
    internal int urenGekocht;
    internal int urenVerbruikt;
    internal int examenPogingen;
    internal bool automaat;
}

internal class TheorieTest
{
    internal int aantalFouten;
    internal bool gehaald;
    internal DateTime afnameDatum;
}

internal class RijTest
{
    internal bool gehaald;
    internal DateTime afnameDatum;
}

internal class Dag
{
    internal DateTime datum;
    internal LesUur[] lesuren;
}

internal class LesUur
{
    internal int tijd;
    internal Student student;
    internal RijLeraar rijLeraar;
    internal Auto auto;       
}

internal class Student
{
    internal string naam;
    internal int leeftijd;
    internal LesPakket lesPakket;
    internal TheorieTest theorieTest;
    internal RijTest rijTest;
}