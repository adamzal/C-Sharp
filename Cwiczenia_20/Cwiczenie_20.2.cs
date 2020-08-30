using System;

public class Punkt
{
    private int[] _wsp= new int[2];
    public int x
    {
        get
        {
            return _wsp[0];
        }
        set
        {
            _wsp[0] = value;
        }
    }
    public int y
    {
        get
        {
            return _wsp[1];
        }
        set
        {
            _wsp[1] = value;
        }
    }
}

class Program
{
    public static void Main()
    {
        Punkt a = new Punkt();
        Console.WriteLine("{0}   {1}",a.x, a.y);
        a.x = 3;
        a.y=5;
        Console.WriteLine("{0}   {1}", a.x, a.y);
        Console.ReadKey();
    }
}
