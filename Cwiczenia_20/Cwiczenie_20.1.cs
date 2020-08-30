using System;

public class Punkt
{
    private int _x=-5;
    private int _y=3;
    public int x
    {
        get
        {
            return _x;
        }
        set
        {
            _x = value;
        }
    }
    public int y
    {
        get
        {
            return _y;
        }
        set
        {
            _y = value;
        }
    }
}

public class Punkt3D : Punkt
{
    private int _z;
    public int z { get; set; } = 11;
}

class Program
{
    public static void Main()
    {
        Punkt a = new Punkt();
        Console.WriteLine("{0}   {1}",a.x, a.y);
        a.x = 3;
        Console.WriteLine("{0}   {1}", a.x, a.y);
        Punkt3D b = new Punkt3D();
        Console.WriteLine("{0}   {1}    {2}", b.x, b.y,b.z);
        Console.ReadKey();
    }
}
