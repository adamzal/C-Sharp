using System;


public class Produkt
{
    string _nazwa;
    public string nazwa
    {
        get
        {
            return _nazwa;
        }
        set
        {
            _nazwa = value;
        }
    }
    int _ilosc;
    public int ilosc
    {
        get
        {
            return _ilosc;
        }
        set
        {
            _ilosc = value;
        }
    }
    string _jednostka;
    public string jednostka
    {
        get
        {
            return _jednostka;
        }
        set
        {
            _jednostka = value;
        }
    }
    double _cena;
    public double cena
    {
        get
        {
            return _cena;
        }
        set
        {
            _cena = value;
        }
    }

    public Produkt() { }
    public Produkt(string nazwa, int ilosc, string jednostka, double cena)
    {
        this.nazwa = nazwa;
        this.ilosc = ilosc;
        this.jednostka = jednostka;
        this.cena = cena;
    }

    public string ProduktInfo()
    {
        return nazwa;
    }
}

