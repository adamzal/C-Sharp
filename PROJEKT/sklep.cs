using System;
using System.IO;

public class Sklep
{
    double zarobek;

    public Sklep()
    {
        StreamReader sr = new StreamReader(new FileStream("sklep.txt", FileMode.OpenOrCreate));
        string line = sr.ReadLine();
        sr.Close();
        if (line != null)
        {
            zarobek = Convert.ToDouble(line);
        }
        else
        {
            zarobek = 0;
        }
    }
    public void sprzedaj(string nazwa, int ilosc)
    {
        Magazyn m = new Magazyn();
        Produkt p = new Produkt();
        p = m.getProdukt(nazwa);
        m.usunZMagazynu(nazwa, ilosc);
        zarobek += p.cena * ilosc;
        StreamWriter sw = new StreamWriter("sklep.txt");
        sw.WriteLine(zarobek);
        sw.Close();
    }
}

