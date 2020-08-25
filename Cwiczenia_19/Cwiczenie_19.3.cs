using System;

class Dodawanie
{
    public static int Dodaj(int a, int b) => a + b;
    public static void Main()
    {
        Console.WriteLine("wynik = "+Dodawanie.Dodaj(10, 3));
        Console.ReadKey();
    }
}
