using System;
using System.IO;


public class Magazyn
{
    Produkt[] produkt;

    public Magazyn()
    {
        wczytaj();
    }

    private void wczytaj()
    {
        StreamReader sr = new StreamReader(new FileStream("magazyn.txt", FileMode.OpenOrCreate));
        string line = sr.ReadLine();
        if (line != null)
        {
            produkt = new Produkt[Int32.Parse(line)];
            for (int i = 0; i < produkt.Length && line != null; i++)
            {
                line = sr.ReadLine();
                string[] s = line.Split(new char[] { ';' });
                produkt[i] = new Produkt(s[0], Int32.Parse(s[1]), s[2], Convert.ToDouble(s[3]));
            }
        }
        else
        {
            produkt = new Produkt[1];
            produkt[0] = new Produkt();
        }
        sr.Close();
    }

    private void zapisz(Produkt[] prod)
    {
        StreamWriter sw = new StreamWriter("magazyn.txt");
        sw.WriteLine(prod.Length);
        for (int i = 0; i < prod.Length; i++)
        {
            sw.WriteLine(prod[i].nazwa + ";" + prod[i].ilosc + ";" + prod[i].jednostka + ";" + prod[i].cena);
        }
        sw.Close();
    }

    public void usunZMagazynu(string nazwa, int ilosc)
    {
        bool czyjest = false;
        for (int i = 0; i < produkt.Length; i++)
        {
            if (produkt[i].nazwa == nazwa)
            {
                czyjest = true;
                if (ilosc < 0)
                {
                    Console.WriteLine("Podano ujemn� ilo�� {0} produktu {1}", ilosc, nazwa);
                }
                else
                {
                    if (produkt[i].ilosc - ilosc < 0)
                    {
                        Console.WriteLine("Na magazynie zosta�o {0} {1} {2} - nie mo�emy sprzeda� {3}.", produkt[i].ilosc, produkt[i].jednostka, produkt[i].nazwa, ilosc);
                    }
                    else
                    {
                        produkt[i].ilosc -= ilosc;
                        zapisz(produkt);
                    }
                }
            }
        }
        if (czyjest == false)
        {
            Console.WriteLine("Produktu {0} nie ma na li�cie", nazwa);
        }
    }

    public void dodajDoMagazynu(string nazwa, int ilosc, string jednostka, double cena)
    {
        if (ilosc < 0)
        {
            Console.WriteLine("Podana ilo�� produktu {0} jest ujemna: {1}", nazwa, ilosc);
        }
        else
        {
            if (cena < 0)
            {
                Console.WriteLine("Podana cena produktu {0} jest ujemna: {1}", nazwa, cena);
            }
            else
            {
                StreamReader sr = new StreamReader(new FileStream("magazyn.txt", FileMode.OpenOrCreate));
                string line = sr.ReadLine();
                sr.Close();
                if (line == null)
                {
                    produkt[0].nazwa = nazwa;
                    produkt[0].ilosc = ilosc;
                    produkt[0].jednostka = jednostka;
                    produkt[0].cena = cena;
                    zapisz(produkt);
                }
                else
                {
                    bool czyistnieje = false;
                    int a = 0;
                    while (!czyistnieje && a < produkt.Length)
                    {
                        if (produkt[a].nazwa == nazwa)
                        {
                            czyistnieje = true;
                            produkt[a].ilosc += ilosc;
                        }
                        a++;
                    }
                    if (!czyistnieje)
                    {
                        Produkt[] pro = new Produkt[produkt.Length + 1];
                        for (int i = 0; i < pro.Length; i++)
                        {
                            pro[i] = new Produkt();
                        }
                        for (int i = 0; i < produkt.Length; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                pro[i] = produkt[i];
                            }
                        }
                        pro[produkt.Length].nazwa = nazwa;
                        pro[produkt.Length].ilosc = ilosc;
                        pro[produkt.Length].jednostka = jednostka;
                        pro[produkt.Length].cena = cena;
                        produkt = pro;
                    }
                    zapisz(produkt);
                }
            }
        }
    }

    public Produkt getProdukt(string nazwa)
    {
        for (int i = 0; i < produkt.Length; i++)
        {
            if (produkt[i].nazwa == nazwa)
            {
                return produkt[i];
            }
        }
        return null;
    }

    public object[] magazynlist()
    {
        string[] lista = new string[produkt.Length];
        for (int i = 0; i < produkt.Length; i++)
        {
            lista[i]=produkt[i].ProduktInfo();
        }
        return lista;
    }
}

