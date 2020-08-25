using System;

class Przykład
{
    private static void Wyswietl()
    {
        Console.WriteLine("Dowolny napis");
    }

    public static void Ujawnij()
    {
        Przykład.Wyswietl();
    }
}

class Program
{
    public static void Main()
    {
        Przykład.Ujawnij();
        Console.ReadKey();
    }
}
