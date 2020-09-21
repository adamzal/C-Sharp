using System;


public class Klient
{
    string _imie;
    public string imie
    {
        get
        {
            return _imie;
        }
        set
        {
            _imie = value;
        }
    }

    string _nazwisko;
    public string nazwisko
    {
        get
        {
            return _nazwisko;
        }
        set
        {
            _nazwisko = value;
        }
    }

    string _adres_email;
    public string adres_email
    {
        get
        {
            return _adres_email;
        }
        set
        {
            _adres_email = value;
        }
    }
    protected string _login;
    public string login
    {
        get
        {
            return _login;
        }
        set
        {
            _login = value;
        }
    }

    protected string _haslo;
    public string haslo
    {
        get
        {
            return _haslo;
        }
        set
        {
            _haslo = value;
        }
    }

    public Klient(string imie=null, string nazwisko=null, string adres_email=null, string login=null,string haslo=null)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.adres_email = adres_email;
        this.login = login;
        this.haslo = haslo;
    }

    public void kup(string nazwa, int ilosc)
    {
        Sklep sk = new Sklep();
        Magazyn m = new Magazyn();
        if (m.getProdukt(nazwa) == null)
        {
            Console.WriteLine("Produktu o nazwie {0} nie ma w asortymencie sklepu", nazwa);
        }
        else
        {
            sk.sprzedaj(nazwa, ilosc);
        }
    }

    public string wyswietlDane()
    {
        return "Imiê:\n" + imie + "\n\n Nazwisko:\n" + nazwisko + "\n\n Adres e-mail:\n" + adres_email;
    }
}

