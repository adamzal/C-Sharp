using System;

public class Ciag
{
    private double _a;
    public double a
    {
        get
        {
            _a = 2 * (_a - 1) - 2;
            return _a;
        }
    }
}

class Program
{
    public static void Main()
    {
        Ciag a = new Ciag();
        Console.WriteLine(a.a);
        Console.WriteLine(a.a);
        Console.WriteLine(a.a);
        Console.ReadKey();
    }
}
