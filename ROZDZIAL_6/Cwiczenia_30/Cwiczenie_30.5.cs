using System;

public class A
{
    public A()
    {
        //Console.WriteLine("Konstruktor klasy A");
        f();
    }
    public void f()
    {
        //Console.WriteLine("Klasa A metoda f()");
    }
}

public class B : A
{
    int dzielnik;
    public B(int dzielnik)
    {
        //Console.WriteLine("Konstruktor klasy B");
        this.dzielnik = dzielnik;
    }
    public void f()
    {
        //Console.WriteLine("Klasa B metoda f()");
        double wynik = 100 / dzielnik;
        Console.WriteLine(
         "Dzielenie całkowite 100 / {0} daje wynik: {1}", dzielnik, wynik);
    }
    public static void Main()
    {
        B b = new B(10);
        b.f();
        Console.ReadKey();
    }
}
