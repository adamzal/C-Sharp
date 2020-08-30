using System;

public class Liczba
{
    private double _a;
    public double a
    {
        get
        {
            return _a*2;
        }
        set
        {
            _a = value/2;
        }
    }

    public double Ujawnij()
    {
        return _a;
    }
}

class Program
{
    public static void Main()
    {
        Liczba a = new Liczba();
        Console.WriteLine("{0}\t{1}",a.Ujawnij(),a.a);
        a.a = 3;
        Console.WriteLine("{0}\t{1}", a.Ujawnij(), a.a);
        a.a=5;
        Console.WriteLine("{0}\t{1}", a.Ujawnij(), a.a);
        Console.ReadKey();
    }
}
