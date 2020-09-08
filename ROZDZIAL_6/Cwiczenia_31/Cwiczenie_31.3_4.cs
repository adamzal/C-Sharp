using System;

public interface INumber
{
    int calkowita { get; set; }
    double wymierna { get; set; }
}

public class Liczby : INumber
{
    private int a;
    private double b;
    public int calkowita        
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
        }
    }
    public double wymierna
    {
        get
        {
            return b;
        }
        set
        {
            b = value;
        }
    }
}
public class Program
{ 
    public static void Main()
    {
        Liczby l = new Liczby();
        l.calkowita = 5;
        l.wymierna = 2.532;
        Console.WriteLine(l.calkowita);
        Console.WriteLine(l.wymierna);
        Console.ReadKey();
    }
}
