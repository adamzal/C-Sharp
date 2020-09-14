using System;

public delegate void OnPrzypisanie();
public class Kontener
{
    public event OnPrzypisanie onCalkowita;
    public event OnPrzypisanie onRzeczywista;
    
    public void Metoda(string napis)
    {
        try
        {
            Int32.Parse(napis);
            if (onCalkowita != null)
                onCalkowita();
        }
        catch (Exception) { }
        try
        {
            Double.Parse(napis);
            if (onRzeczywista != null)
                onRzeczywista();
        }
        catch (Exception) { }
    }
}

public class Program
{
    public static void onCalk()
    {
        Console.WriteLine("Można przepisać na liczbę całkowitą");
    }
    public static void onRzec()
    {
        Console.WriteLine("Można przepisać na liczbę rzeczywistą");
    }
    public static void Main()
    {
        Kontener k=new Kontener();
        k.onCalkowita += onCalk;
        k.onRzeczywista += onRzec;
        k.Metoda("3,654");
        Console.WriteLine("---");
        k.Metoda("7654");
        Console.WriteLine("---");
        k.Metoda("-76,6543245");
        Console.WriteLine("---");
        k.Metoda("-6543");
        Console.ReadKey();
    }
}
