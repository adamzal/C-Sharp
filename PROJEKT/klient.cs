public class Klient
{
    string imie;
    string nazwisko;
    string adres_email;
    double dostepne_srodki;
    double ile_wydane;

    public Klient(string imie,string nazwisko,string adres_email)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.adres_email = adres_email;
        dostepne_srodki = 0;
        ile_wydane = 0;
    }

    public void kup(string nazwa,int ilosc)
    {
        Sklep sk = new Sklep();
        Magazyn m = new Magazyn();
        Produkt p = new Produkt();
        if(m.getProdukt(nazwa)==null)
        {
            Console.WriteLine("Produktu o nazwie {0} nie ma w asortymencie sklepu",nazwa);
        }
        else
        {
            p = m.getProdukt(nazwa);
            if (p.cena * ilosc > dostepne_srodki)
            {
                Console.WriteLine("Nie masz wystarczająco dużo pieniędzy aby kupić {0} {1} {2}", ilosc, p.jednostka, nazwa);
            }
            else
            {
                dostepne_srodki -= p.cena * ilosc;
                ile_wydane += p.cena * ilosc;
                sk.sprzedaj(nazwa, ilosc);
            }
        }        
    }

    public void doladujKonto(double kwota)
    {
        dostepne_srodki += kwota;
    }

    public void wyswietlDane()
    {
        Console.WriteLine("Imię: {0} Nazwisko: {1} Adres e-mail: {2} Dostępne środki: {3} zł Wydane środki: {4} zł", imie, nazwisko, adres_email, dostepne_srodki,ile_wydane);
    }
}
