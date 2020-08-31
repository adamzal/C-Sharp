using System;

class Przechowalnia
{
    public static int liczba;
    public static int Przechowaj(int a)
    {
        int pom = Przechowalnia.liczba;
        Przechowalnia.liczba = a;
        return pom;
    }
    public static void Main()
    {
        Console.WriteLine("wynik = "+Przechowalnia.Przechowaj(1));
        Console.WriteLine("wynik = " + Przechowalnia.Przechowaj(2));
        Console.WriteLine("wynik = " + Przechowalnia.Przechowaj(3));
        Console.ReadKey();
    }
}
