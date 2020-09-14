using System;

public class Program
{
    public delegate string Delegacja(double a,double b);

    public static string Odejmowanie(double a, double b) => Convert.ToString(a - b);

    public static void Main()
    {
        Delegacja del = Odejmowanie;
        Console.WriteLine(del(13.567,12.89));        
        Console.ReadKey();
    }
}
