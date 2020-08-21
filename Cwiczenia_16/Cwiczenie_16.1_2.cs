using System;

class Wartosc
{
    int liczba;
    Wartosc(int liczba)
    {
        this.liczba = liczba;
    }

    Wartosc():this(-1)
    { }

    public static void Main()
    {
        Wartosc w = new Wartosc(4);
        Wartosc p = new Wartosc();
        Console.WriteLine(w.liczba);
        Console.WriteLine(p.liczba);
        Console.ReadKey();
    }
}
