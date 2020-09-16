using System;

public class Produkt
{
    string nazwa;
    int ilosc;
    string jednostka;
    double cena;

    public Produkt(string nazwa,int ilosc,string jednostka,double cena)
    {
        this.nazwa = nazwa;
        this.ilosc = ilosc;
        this.jednostka = jednostka;
        this.cena = cena;
    }
    
    public void ProduktInfo()
    {
        Console.WriteLine("Produkt: {0} \t Ilość: {1} {2} \t Cena: {3}", nazwa, ilosc, jednostka, cena);
    }
}
