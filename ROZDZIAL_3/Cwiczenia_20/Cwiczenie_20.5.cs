using System;

public struct Punkt
{
    private int _x;
    private int _y;
    public Punkt(int wspx,int wspy)
    {
        _x = wspx;
        _y = wspy;
    }
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

class Program
{
    public static void Main()
    {
        Punkt a = new Punkt(-1,3);
        Console.WriteLine("{0}\t{1}",a.x,a.y);
        a.x = -3;
        a.y = 1;
        Console.WriteLine("{0}\t{1}", a.x, a.y);
        Console.ReadKey();
    }
}
