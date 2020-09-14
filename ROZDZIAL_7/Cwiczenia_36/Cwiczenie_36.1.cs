using System;

public class Program
{
    public delegate void Delegacja1();
    public delegate void Delegacja2(string napis);

    public static void Metoda1()
    {
        Console.WriteLine("Metoda1");
    }
    public static void Metoda2(string napis)
    {
        Console.WriteLine(napis);
    }
    public static void Main()
    {
        Delegacja1 del1 = Metoda1;
        Delegacja2 del2 = Metoda2;
        del1();
        del2("Metoda2");
        Console.ReadKey();
    }
}
