using System;

public interface IPunkt
{
    int x
    {
        get;
        set;
    }
    int y
    {
        get;
        set;
    }
}

public struct Punkt:IPunkt
{
    public int x { get; set; }
    public int y { get; set; }
}

class Program
{
    public static void Main()
    {
        Punkt a = new Punkt();
        Console.WriteLine("{0}\t{1}",a.x,a.y);
        a.x = -3;
        a.y = 1;
        Console.WriteLine("{0}\t{1}", a.x, a.y);
        Console.ReadKey();
    }
}
