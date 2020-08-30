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
        if(indeks<0)
        {
            _blad = true;
            _zakres=-1;
            return 0;
        }
        if(indeks>=tablica.Length)
        {
            _blad = true;
            _zakres=1;
            return 0;
        }
        else
        {
            _blad = false;
            return tablica[indeks];
        }
    }

    public int ustawElement(int indeks,int wartosc)
    {
        if (indeks < 0)
        {
            _blad = true;
            _zakres = -1;
            return 0;
        }
        if (indeks >= tablica.Length)
        {
            _blad = true;
            _zakres = 1;
            return 0;
        }
        else
        {
            _blad = false;
            tablica[indeks] = wartosc;
            return 1;
        }
    }

}

class Program
{
    public static void Main()
    {
        Tablica tab = new Tablica();
        tab.ustawElement(11, 10);
        if (tab.wystapilBlad)
        {
            if (tab.zakres == -1)
                Console.WriteLine("Za mały indeks!");
            if (tab.zakres == 1)
                Console.WriteLine("Za duży indeks!");
        }
        else
        {
            tab.ustawElement(5, 1);
        }
        int liczba1 = tab.pobierzElement(5);
        if (tab.wystapilBlad)
        {
            if (tab.zakres == -1)
                Console.WriteLine("Za mały indeks!");
            if (tab.zakres == 1)
                Console.WriteLine("Za duży indeks!");
        }
        else
        {
            Console.WriteLine(liczba1);
        }
        int liczba2 = tab.pobierzElement(-3);
        if (tab.wystapilBlad)
        {
            if (tab.zakres == -1)
                Console.WriteLine("Za mały indeks!");
            if (tab.zakres == 1)
                Console.WriteLine("Za duży indeks!");
        }
        else
        {
            Console.WriteLine(liczba2);
        }
        int liczba3 = tab.pobierzElement(10);
        if (tab.wystapilBlad)
        {
            if (tab.zakres == -1)
                Console.WriteLine("Za mały indeks!");
            if(tab.zakres==1)
                Console.WriteLine("Za duży indeks!");
        }
        else
        {
            Console.WriteLine(liczba3);
        }
        Console.ReadKey();
    }
}
