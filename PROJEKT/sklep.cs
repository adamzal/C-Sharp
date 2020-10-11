using System;
using System.IO;

public class Sklep
{
    public void sprzedaj(string nazwa, int ilosc)
    {
        Magazyn m = new Magazyn();
        Produkt p = new Produkt();
        p = m.getProdukt(nazwa);
        m.usunZMagazynu(nazwa, ilosc);
    }
}

