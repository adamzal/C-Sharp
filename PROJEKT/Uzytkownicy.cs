using System;
using System.IO;

public class Uzytkownicy
{
    Klient[] uzytkownicy;

    private void wczytaj()
    {
        StreamReader sr = new StreamReader(new FileStream("uzytkownicy.txt", FileMode.OpenOrCreate));
        string line = sr.ReadLine();
        if (line != null)
        {
            uzytkownicy = new Klient[Int32.Parse(line)];
            for (int i = 0; i < uzytkownicy.Length && line != null; i++)
            {
                line = sr.ReadLine();
                string[] s = line.Split(new char[] { ';' });
                uzytkownicy[i] = new Klient(s[0], s[1], s[2], s[3], s[4]);
            }
        }
        else
        {
            uzytkownicy = new Klient[1];
            uzytkownicy[0] = new Klient();
        }
        sr.Close();
    }

    void zapisz(Klient[] uzyt)
    {
        StreamWriter sw = new StreamWriter("uzytkownicy.txt");
        sw.WriteLine(uzyt.Length);
        for (int i = 0; i < uzyt.Length; i++)
        {
            sw.WriteLine(uzyt[i].imie + ";" + uzyt[i].nazwisko + ";" + uzyt[i].adres_email + ";" + uzyt[i].login + ";" + uzyt[i].haslo);
        }
        sw.Close();
    }

    public void usunUzytkownika(string adresemail)
    {
        bool czyjest = false;
        for (int i = 0; i < uzytkownicy.Length; i++)
        {
            if (uzytkownicy[i].adres_email == adresemail)
            {
                czyjest = true;

            }
        }
        if (czyjest == false)
        {
            Console.WriteLine("Uzytkownika o adresie e-mail: {0} nie ma na liście", adresemail);
        }
    }

    public void dodajUzytkownika(string imie, string nazwisko, string adresemail, string login, string haslo)
    {

        StreamReader sr = new StreamReader(new FileStream("uzytkownicy.txt", FileMode.OpenOrCreate));
        string line = sr.ReadLine();
        sr.Close();
        if (line == null)
        {
            uzytkownicy[0].imie = imie;
            uzytkownicy[0].nazwisko = nazwisko;
            uzytkownicy[0].adres_email = adresemail;
            uzytkownicy[0].login = login;
            uzytkownicy[0].haslo = haslo;
            zapisz(uzytkownicy);
        }
        else
        {
            bool czyistnieje = false;
            int a = 0;
            while (!czyistnieje && a < uzytkownicy.Length)
            {
                if (uzytkownicy[a].adres_email == adresemail)
                {
                    czyistnieje = true;
                }
                a++;
            }
            if (!czyistnieje)
            {
                Klient[] pro = new Klient[uzytkownicy.Length + 1];
                for (int i = 0; i < pro.Length; i++)
                {
                    pro[i] = new Klient();
                }
                for (int i = 0; i < uzytkownicy.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        pro[i] = uzytkownicy[i];
                    }
                }
                pro[uzytkownicy.Length].imie = imie;
                pro[uzytkownicy.Length].nazwisko = nazwisko;
                pro[uzytkownicy.Length].adres_email = adresemail;
                pro[uzytkownicy.Length].login = login;
                pro[uzytkownicy.Length].haslo = haslo;
                uzytkownicy = pro;
            }
            zapisz(uzytkownicy);
        }
    }
}

