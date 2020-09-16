using System;
using System.IO;

public class Magazyn
{
    private Object[][] produkt;
    
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
            produkt = new Object[Int32.Parse(line)][];
            for (int i = 0; i < Int32.Parse(line); i++)
            {
                produkt[i] = new Object[4];
            }
            line = sr.ReadLine();
            int j = 0;
            while (line != null)
            {
                string[] s = line.Split(new char[] { ';' });
                produkt[j][0] = s[0];
                produkt[j][1] = s[1];
                produkt[j][2] = s[2];
                produkt[j][3] = s[3];
                j++;
                line = sr.ReadLine();
            }
        }
        else
        {
            produkt = new Object[1][];
            produkt[0] = new Object[4];
        }
        sr.Close();
    }

    private void zapisz()
    {
        StreamWriter sw = new StreamWriter("magazyn.txt");
        sw.WriteLine(produkt.Length);
        for (int i = 0; i < produkt.Length; i++)
        {
            sw.WriteLine(produkt[i][0] + ";" + produkt[i][1] + ";" + produkt[i][2] + ";" + produkt[i][3]);
        }
        sw.Close();
    }

    public void usuńZMagazynu(string nazwa,int ilosc)
    {
        for(int i=0;i<produkt.Length;i++)
        {
            if (Convert.ToString(produkt[i][0]) == nazwa)
            {
                if (ilosc < 0)
                {
                    Console.WriteLine("Podano ujemną wartość");
                }
                else
                {
                    if (Convert.ToInt32(produkt[i][1]) - ilosc < 0)
                    {
                        Console.WriteLine("Na magazynie zostało {0} {1} {2} - nie możemy sprzedać {3}.", produkt[i][1], produkt[i][2], produkt[i][0], ilosc);
                    }
                    else
                    {
                        produkt[i][1] = Convert.ToInt32(produkt[i][1]) - ilosc;
                        zapisz();
                    }

                }
            }
        }
    }

    public void dodajDoMagazynu(string nazwa, int ilosc,string jednostka,double cena)
    {        
        if(ilosc<0||cena<0)
        {
            Console.WriteLine("Podano ujemna wartosc");
        }
        else
        { 
        StreamReader sr = new StreamReader(new FileStream("magazyn.txt", FileMode.OpenOrCreate));
        string line = sr.ReadLine();
            if (line == null)
            {
                sr.Close();
                produkt[0][0] = nazwa;
                produkt[0][1] = ilosc;
                produkt[0][2] = jednostka;
                produkt[0][3] = cena;
                zapisz();
            }
            else
            {
                sr.Close();
                bool czyistnieje = false;
                int a = 0;
                while (!czyistnieje && a < produkt.Length)
                {
                    if (Convert.ToString(produkt[a][0]) == nazwa)
                    {
                        czyistnieje = true;
                        produkt[a][1] = Convert.ToInt32(produkt[a][1]) + ilosc;
                    }
                    a++;
                }
                if (!czyistnieje)
                {
                    Object[][] obj = new Object[produkt.Length + 1][];
                    for (int i = 0; i < produkt.Length + 1; i++)
                    {
                        obj[i] = new Object[4];
                    }
                    for (int i = 0; i < produkt.Length; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            obj[i][j] = produkt[i][j];
                        }
                    }
                    obj[produkt.Length][0] = nazwa;
                    obj[produkt.Length][1] = ilosc;
                    obj[produkt.Length][2] = jednostka;
                    obj[produkt.Length][3] = cena;
                    produkt = obj;
                    zapisz();
                }                
            }
        }                       
    }

    public void wyswietlMagazyn()
    {
        for (int i=0;i<produkt.Length;i++)
        {            
            for(int j=0;j<4;j++)
            {
                Console.Write(produkt[i][j] + "\t");
            }
            Console.WriteLine("");
        }
    }

    public static void Main()
    {
        Magazyn m = new Magazyn();
        m.wyswietlMagazyn();
        Console.ReadKey();
    }
}
