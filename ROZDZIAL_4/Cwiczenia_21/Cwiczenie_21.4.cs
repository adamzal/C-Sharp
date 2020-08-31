using System;

public class Tablica
{
    private int[] tablica = new int[10];
    private bool _blad = false;
    private int _zakres=0;
    public bool wystapilBlad
    {
        get
        {
            return _blad;
        }
    }

    public int zakres
    {
        get
        {
            return _zakres;
        }
    }

    public int pobierzElement(int indeks)
    {
        _blad = false;
        try
        {
            return tablica[indeks];
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("pobierzElement poza zakresem!");
            _blad = true;
            return 0;
        }
    }

    public void ustawElement(int indeks,int wartosc)
    {
        _blad = false;
        try
        {
            tablica[indeks] = wartosc;
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("ustawElement poza zakresem!");
            _blad = true;
        }
    }

}

class Program
{
    public static void Main()
    {
        Tablica tab = new Tablica();
        tab.ustawElement(5, 10);
        int liczba1 = tab.pobierzElement(5);
        int liczba2 = tab.pobierzElement(-3);
        int liczba3 = tab.pobierzElement(10);
        Console.ReadKey();
    }
}
