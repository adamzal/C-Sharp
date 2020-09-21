using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class MainForm : Form
{
    Label nielog = new Label();
    Button Blog = new Button();
    Button Brej = new Button();

    Button Lzaloguj = new Button();    
    Label Llogin = new Label();
    Label Lhaslo = new Label();
    TextBox Lhas = new TextBox();
    TextBox Llog = new TextBox();

    Button zarejestruj = new Button();
    Button powrot = new Button();
    Label imie = new Label();
    TextBox im = new TextBox();
    Label nazwisko = new Label();
    TextBox naz = new TextBox();
    Label email = new Label();
    TextBox ema = new TextBox();
    Label login = new Label();
    TextBox log = new TextBox();
    Label haslo1 = new Label();
    TextBox has1 = new TextBox();
    Label haslo2 = new Label();
    TextBox has2 = new TextBox();

    Klient[] user;

    Label profil = new Label();

    ComboBox lista = new ComboBox();
    Label listprod = new Label();
    Label ilosc = new Label();
    TextBox ilosctext = new TextBox();
    Button dodaj = new Button();

    string wybrany;
    string[] koszyk;
    Label kosz = new Label();
    public MainForm()
    {        
        Width = 500;
        Height = 500;
        noLogin();
    }

    void noLogin(object sender=null,EventArgs ea=null)
    {
        ukryj();
        Text = "Strona startowa";
        MainMenu mm=new MainMenu();
        Menu = mm;
        Brej.Text = "Rejestracja";
        Brej.Visible = true;
        Blog.Text = "Logowanie";
        Blog.Visible = true;
        Brej.Left = (ClientSize.Width - Brej.Width) / 3;
        Brej.Top = (ClientSize.Height - Brej.Height) * 3 / 5;
        Blog.Left = (ClientSize.Width - Blog.Width) * 2 / 3;
        Blog.Top = (ClientSize.Height - Blog.Height) * 3 / 5;
        nielog.Text = "Nie jesteś zalogowany!";
        nielog.Visible = true;
        nielog.Width = ClientSize.Width;
        nielog.Top = (ClientSize.Height - nielog.Height) * 2 / 5;
        nielog.TextAlign = ContentAlignment.TopCenter;
        Controls.Add(Brej);
        Controls.Add(Blog);
        Controls.Add(nielog);
        Blog.Click += Logowanieform;
        Brej.Click += Rejestracjaform;
    }

    void Profilform(object sender, EventArgs ea)
    {
        ukryj();
        Text = "Twój profil";
        profil.Visible = true;
        profil.Text = "";        
        profil.Text = user[0].wyswietlDane();
        profil.TextAlign = ContentAlignment.TopCenter;
        profil.Width = profil.Height = 200;
        profil.Top= (ClientSize.Height - profil.Height) / 2;
        profil.Left= (ClientSize.Width - profil.Width) / 2;
        Controls.Add(profil);

    }

    void Koszykform(object sender, EventArgs ea)
    {
        ukryj();
        Text = "Koszyk";
        string show = "";
        for(int i =0;i<koszyk.Length;i++)
        {
            show += koszyk[i] + "\n";
        }
        kosz.Text = show;
        kosz.TextAlign = ContentAlignment.TopCenter;        
        kosz.Width = ClientSize.Width;
        kosz.Height = ClientSize.Height;
        Controls.Add(kosz);
    }

    void Rejestracjaform(object sender,EventArgs ea)
    {
        ukryj();
        Text = "Rejestracja";
        zarejestruj.Text = "Zarejestruj";
        powrot.Text = "Powrót";
        zarejestruj.Visible = true;
        imie.Text = "Imię:";
        imie.Visible = true;
        nazwisko.Text = "Nazwisko:";
        nazwisko.Visible = true;
        email.Text = "Adres e-mail:";
        email.Visible = true;
        login.Text = "Login:";
        login.Visible = true;        
        haslo1.Text = "Hasło:";
        haslo1.Visible = true;
        haslo2.Text = "Powtórz hasło:";
        haslo2.Visible = true;        
        naz.Visible=im.Visible=ema.Visible=log.Visible=has1.Visible=has2.Visible =powrot.Visible= true;
        naz.Text = im.Text = ema.Text = log.Text = has1.Text = has2.Text = "";

        ema.Width = 200;
        imie.TextAlign= ContentAlignment.TopCenter;
        nazwisko.TextAlign= ContentAlignment.TopCenter;
        email.TextAlign= ContentAlignment.TopCenter;
        login.TextAlign= ContentAlignment.TopCenter;
        haslo1.TextAlign= ContentAlignment.TopCenter;
        haslo2.TextAlign= ContentAlignment.TopCenter;

        im.TextAlign = HorizontalAlignment.Center;
        naz.TextAlign = HorizontalAlignment.Center;
        ema.TextAlign= HorizontalAlignment.Center;
        log.TextAlign= HorizontalAlignment.Center;
        has1.TextAlign= HorizontalAlignment.Center;
        has2.TextAlign= HorizontalAlignment.Center;


        int a=2, b=18;
        imie.Left = (ClientSize.Width - imie.Width-nazwisko.Width) /3 ;
        imie.Top = (ClientSize.Height - imie.Height) * a / b;

        im.Left = (ClientSize.Width - im.Width-naz.Width) /3;
        im.Top = (ClientSize.Height - im.Height) * ++a / b;
        --a;
        nazwisko.Left = (ClientSize.Width - nazwisko.Width-imie.Width);
        nazwisko.Top = (ClientSize.Height - nazwisko.Height) * a / b;

        naz.Left = (ClientSize.Width - naz.Width-im.Width);
        naz.Top = (ClientSize.Height - naz.Height) * ++a / b;
        a++;
        email.Left = (ClientSize.Width - email.Width) / 2;
        email.Top = (ClientSize.Height - email.Height) * ++a / b;

        ema.Left = (ClientSize.Width - ema.Width) / 2;
        ema.Top = (ClientSize.Height - ema.Height) * ++a / b;
        a++;
        login.Left = (ClientSize.Width - login.Width) / 2;
        login.Top = (ClientSize.Height - login.Height) * ++a / b;

        log.Left = (ClientSize.Width - log.Width) / 2;
        log.Top = (ClientSize.Height - log.Height) * ++a / b;
        a++;
        haslo1.Left = (ClientSize.Width - haslo1.Width) / 2;
        haslo1.Top = (ClientSize.Height - haslo1.Height) * ++a / b;

        has1.Left = (ClientSize.Width - has1.Width) / 2;
        has1.Top = (ClientSize.Height - has1.Height) * ++a / b;
        a++;
        haslo2.Left = (ClientSize.Width - haslo2.Width) / 2;
        haslo2.Top = (ClientSize.Height - haslo2.Height) * ++a / b;

        has2.Left = (ClientSize.Width - has2.Width) / 2;
        has2.Top = (ClientSize.Height - has2.Height) * ++a / b;
        a++;
        powrot.Top = zarejestruj.Top = (ClientSize.Height - zarejestruj.Height) * ++a / b;
        zarejestruj.Left = (ClientSize.Width - zarejestruj.Width) /3;

        powrot.Left = (ClientSize.Width - powrot.Width) * 2/3;

        zarejestruj.Click += onZarejestrujClick;
        powrot.Click += noLogin;

        has1.PasswordChar = '*';
        has2.PasswordChar = '*';
        Controls.Add(imie);
        Controls.Add(im);
        Controls.Add(nazwisko);
        Controls.Add(naz);
        Controls.Add(email);
        Controls.Add(ema);
        Controls.Add(login);
        Controls.Add(log);
        Controls.Add(haslo1);
        Controls.Add(has1);
        Controls.Add(haslo2);
        Controls.Add(has2);
        Controls.Add(zarejestruj);
        Controls.Add(powrot);
        
    }

    void Logowanieform(object sender, EventArgs ea)
    {
        ukryj();
        Text = "Logowanie";
        Lzaloguj.Text = "Zaloguj";
        Lzaloguj.Visible = true;
        Llogin.Text = "Podaj swój login:";
        Llogin.Visible = true;
        Lhaslo.Text = "Podaj swoje hasło:";
        Lhaslo.Visible = true;
        powrot.Text = "Powrót";
        Llog.Visible = true;
        Llog.Text = "";
        Lhas.Visible = true;
        Lhas.Text = "";
        powrot.Visible = true;

        Llogin.Left = (ClientSize.Width - Llogin.Width) / 2;
        Llogin.Top = (ClientSize.Height - Llogin.Height) * 2 / 9;

        Llog.Left = (ClientSize.Width - Llog.Width) / 2;
        Llog.Top = (ClientSize.Height - Llog.Height) * 3 / 9;

        Lhaslo.Left = (ClientSize.Width - Lhaslo.Width) / 2;
        Lhaslo.Top = (ClientSize.Height - Lhaslo.Height) * 5 / 9;

        Lhas.Left = (ClientSize.Width - Lhas.Width) / 2;
        Lhas.Top = (ClientSize.Height - Lhas.Height) * 6 / 9;

        Lzaloguj.Left = (ClientSize.Width - Lzaloguj.Width) / 3;
        powrot.Top=Lzaloguj.Top = (ClientSize.Height - Lzaloguj.Height) * 8 / 9;

        powrot.Left = (ClientSize.Width - powrot.Width) * 2/3;

        Llogin.TextAlign = ContentAlignment.TopCenter;
        Llog.TextAlign = HorizontalAlignment.Center;
        Lhaslo.TextAlign = ContentAlignment.TopCenter;
        Lhas.TextAlign = HorizontalAlignment.Center;

        Lzaloguj.Click += onZalogujClick;
        powrot.Click += noLogin;

        Lhas.PasswordChar = '*';       
        Controls.Add(Llogin);
        Controls.Add(Llog);
        Controls.Add(Lhaslo);
        Controls.Add(Lhas);
        Controls.Add(Lzaloguj);
        Controls.Add(powrot);
    }

    void Sklepform()
    {
        ukryj();
        Text = "Sklep";
        MainMenu mm = new MainMenu();
        MenuItem daneKlient = new MenuItem("Twój profil");
        MenuItem koszyk = new MenuItem("Twój koszyk");
        MenuItem wyloguj = new MenuItem("Wyloguj");
        mm.MenuItems.Add(daneKlient);
        mm.MenuItems.Add(koszyk);
        mm.MenuItems.Add(wyloguj);
        Menu = mm;
        daneKlient.Click += Profilform;
        koszyk.Click += Koszykform;
        wyloguj.Click += onWylogujClick;
        Magazyn m = new Magazyn();
        lista.Items.AddRange
            (
            m.magazynlist()
            );

        ilosc.Text = "Ilość:";
        ilosc.Visible = true;
        listprod.Text = "Oferta sklepu:";
        listprod.Visible = true;
        dodaj.Text = "Dodaj";
        dodaj.Visible = true;
        lista.Visible = true;
        ilosctext.Visible = true;
        
        lista.Top = (ClientSize.Height-lista.Height)*3/6;
        lista.Left = (ClientSize.Width - lista.Width) / 3;

        listprod.Top = (ClientSize.Height - listprod.Height) * 2 / 5;
        listprod.Left = (ClientSize.Height - listprod.Width) / 3;

        ilosc.Top = (ClientSize.Height - ilosc.Height) * 2 / 5;
        ilosc.Left = (ClientSize.Width - ilosc.Width)*2/3 ;

        ilosctext.Top= (ClientSize.Height - ilosctext.Height) * 3 / 6;
        ilosctext.Left = (ClientSize.Width - ilosctext.Width)*2/3;

        dodaj.Top = (ClientSize.Height - dodaj.Height) * 4 / 6;
        dodaj.Left=(ClientSize.Width - dodaj.Width) / 2;

        lista.DropDownWidth = 200;
        listprod.TextAlign = ContentAlignment.TopCenter;
        ilosc.TextAlign = ContentAlignment.TopCenter;
        ilosctext.TextAlign = HorizontalAlignment.Center;

        lista.SelectedIndexChanged += onListSelect;
        dodaj.Click += onDodaj;
        Controls.Add(lista);
        Controls.Add(ilosctext);
        Controls.Add(listprod);
        Controls.Add(ilosc);
        Controls.Add(dodaj);
    }
    void ukryj()
    {
        lista.Visible=listprod.Visible=dodaj.Visible=ilosc.Visible=ilosctext.Visible= profil.Visible = powrot.Visible = nielog.Visible = Blog.Visible = Brej.Visible = Lzaloguj.Visible = Llogin.Visible = Llog.Visible = Lhaslo.Visible = Lhas.Visible = zarejestruj.Visible = imie.Visible = im.Visible = login.Visible = has1.Visible = has2.Visible = haslo1.Visible = haslo2.Visible = nazwisko.Visible = naz.Visible = log.Visible = email.Visible = ema.Visible = false;
    }

    void onListSelect(object sender = null, EventArgs ea = null)
    {
        wybrany= ((ComboBox)sender).SelectedItem.ToString();
    }
    void onDodaj(object sender=null, EventArgs ea=null)
    {
        if(koszyk==null)
        {
            koszyk = new string[1];
            koszyk[0] = wybrany;
        }
        else
        {
            string[] kos = new string[koszyk.Length + 1];
            for(int i=0;i<koszyk.Length;i++)
            {
                kos[i] = koszyk[i];
            }
            kos[koszyk.Length + 1] = wybrany;
            koszyk = kos;
        }
    }

    void onWylogujClick(object sender,EventArgs ea)
    {
        ukryj();     
        noLogin();
    }

    void onZalogujClick(object sender, EventArgs ea)
    {
        bool zalogowany = false;
        if(zalogowany==false)
        {
            StreamReader sr = new StreamReader(new FileStream("uzytkownicy.txt", FileMode.OpenOrCreate));
            string line = sr.ReadLine();
            int a = Int32.Parse(line);
            if (line != null)
            {
                user = new Klient[1];
                for (int i = 0; i < a && line != null; i++)
                {
                    line = sr.ReadLine();                    
                    string[] s = line.Split(new char[] { ';' });
                    if(s[3]==Llog.Text&&s[4]==Lhas.Text)
                    {
                        user[0] = new Klient(s[0], s[1], s[2], s[3], s[4]);
                        zalogowany = true;
                        break;
                    }
                }                
            }
            sr.Close();
        }
        if (zalogowany)
        {            
            Sklepform();
        }
        else
        {
            MessageBox.Show("Zalogowanie użytkownika nie powiodło się\n Sprawdź czy wpisałeś prawidłowe dane.\n Jeżeli nie posiadasz konta - zarejestruj się.", "Uwaga!");
        }
    }

    void onZarejestrujClick(object sender, EventArgs ea)
    {       
        bool rej = false;
        if(has1.Text==has2.Text)
        {
            if (rej == false)
            {
                StreamReader sr = new StreamReader(new FileStream("uzytkownicy.txt", FileMode.OpenOrCreate));
                string line = sr.ReadLine();
                sr.Close();
                if (line == null)
                {
                    user = new Klient[1];
                    user[0] = new Klient(im.Text, naz.Text, ema.Text, log.Text, has1.Text);
                    zapisz(user);
                }
                else
                {
                    wczytaj();
                    bool czyloginistnieje = false;
                    bool czyemailistnieje = false;
                    for (int i = 0; i < user.Length && !czyloginistnieje; i++)
                    {
                        if (user[i].login == log.Text)
                        {
                            czyloginistnieje = true;
                            MessageBox.Show("Podany login jest zajęty.", "Uwaga!");
                        }
                        if (user[i].adres_email == ema.Text)
                        {
                            czyemailistnieje = true;
                            MessageBox.Show("Istnieje użytkownik z podanym adresem a-mail.", "Uwaga!");
                        }
                    }
                    if (!czyemailistnieje && !czyloginistnieje)
                    {
                        Klient[] us = new Klient[user.Length + 1];
                        for (int i = 0; i < us.Length; i++)
                        {
                            us[i] = new Klient();
                        }
                        for (int i = 0; i < user.Length; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                us[i] = user[i];
                            }
                        }
                        us[user.Length].imie = im.Text;
                        us[user.Length].nazwisko = naz.Text;
                        us[user.Length].adres_email = ema.Text;
                        us[user.Length].login = log.Text;
                        us[user.Length].haslo = has1.Text;
                        user = us;
                    }
                    zapisz(user);
                    rej = true;
                }
            }
            if (rej)
            {
                MessageBox.Show("Rejestracja użytkownika powiodła się SUKCESEM\n Zaloguj się do sklepu.", "Komunikat");
                noLogin();
            }
            else
            {
                MessageBox.Show("Rejestracja użytkownika nie powiodła się\n Sprawdź czy wpisałeś prawidłowe dane.", "Uwaga!");
            }
        }
        else
        {
            MessageBox.Show("Podane hasła różnią się.", "Uwaga!");
        }        
    }

    private void wczytaj()
    {
        StreamReader sr = new StreamReader(new FileStream("uzytkownicy.txt", FileMode.OpenOrCreate));
        string line = sr.ReadLine();
        if (line != null)
        {
            user = new Klient[Int32.Parse(line)];
            for (int i = 0; i < user.Length && line != null; i++)
            {
                line = sr.ReadLine();
                string[] s = line.Split(new char[] { ';' });
                user[i] = new Klient(s[0], s[1], s[2], s[3], s[4]);
            }
        }
        else
        {
            user = new Klient[1];
            user[0] = new Klient();
        }
        sr.Close();
    }

    private void zapisz(Klient[] u)
    {
        StreamWriter sw = new StreamWriter("uzytkownicy.txt");
        sw.WriteLine(u.Length);
        for (int i = 0; i < u.Length; i++)
        {
            sw.WriteLine(u[i].imie + ";" + u[i].nazwisko + ";" + u[i].adres_email + ";" + u[i].login+";"+u[i].haslo);
        }
        sw.Close();
    }
}

public class Program
{
    public static void Main()
    {
        Application.Run(new MainForm());
    }

}
