using System;
using System.IO;
using System.Windows.Forms;

public class MainForm : Form
{
    public MainForm(string tytul, int szerokosc, int wysokosc, MainMenu mm)
    {
        Text = tytul;
        Width = szerokosc;
        Height = wysokosc;
        Menu = mm;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string tytul = "Tytuł domyślny";
        int szerokosc = 320;
        int wysokosc = 200;
        MainMenu mm = new MainMenu();
        try
        {
            StreamReader sr = new StreamReader(Console.ReadLine());

            int count = Int32.Parse(sr.ReadLine());
            for (int i = 0; i < count; i++)
            {
                mm.MenuItems.Add(new MenuItem(sr.ReadLine()));
            }
            for (int i = 0; i < count; i++)
            {
                int count2 = Int32.Parse(sr.ReadLine());
                for (int j = 0; j < count2; j++)
                {
                    mm.MenuItems[i].MenuItems.Add(new MenuItem(sr.ReadLine()));
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        Application.Run(new MainForm(tytul, szerokosc, wysokosc, mm));
    }
}
