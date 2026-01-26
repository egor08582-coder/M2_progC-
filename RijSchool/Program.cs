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