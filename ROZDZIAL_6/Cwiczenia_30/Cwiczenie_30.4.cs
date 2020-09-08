using System;

public class Glowna
{
    public Glowna()
    {
        Console.WriteLine("Konstruktor klasy Glowna");
    }
}

public class Potomna : Glowna
{
    public Potomna()
    {
        Console.WriteLine("Konstruktor klasy Potomna");
    }
}

public class Program:Potomna
{
    Glowna obiekt1 = new Glowna();
    Glowna obiekt2 = new Potomna();
    public Program()
    {
        Console.WriteLine("Konstruktor klasy Program");
    }
    public static void Main()
    {
        Program obiektC = new Program();
        Console.ReadKey();
    }
}
