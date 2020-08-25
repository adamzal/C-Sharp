using System;

class Punkt
{
    private double sinusalfa;
    private double r;
    private bool xujemne;

    public int PobierzX()
    { 
        double x = r * Math.Sqrt(1 - sinusalfa * sinusalfa);
        return xujemne==true ? -(int)x : (int) x;
    }

    public int PobierzY()
    {
        double y = r * sinusalfa;
        return (int) y;
    }

    public void UstawX(int wspx)
    {
        int x = wspx;
        int y = PobierzY();
        xujemne = x < 0 ? true : false;

        r = Math.Sqrt(x * x + y * y);
        sinusalfa = r == 0 ? 0 : y / r;
    }

    public void UstawY(int wspy)
    {
        int x = PobierzX();
        int y = wspy;

        r = Math.Sqrt(x * x + y * y);
        sinusalfa = r == 0 ? 0 : y / r;
    }

    public static void Main()
    {
        Punkt p = new Punkt();
        p.UstawX(-1);
        p.UstawY(-1);
        Console.WriteLine("x = " + p.PobierzX());
        Console.WriteLine("y = " + p.PobierzY());
        p.UstawX(0);
        p.UstawY(0);
        Console.WriteLine("x = " + p.PobierzX());
        Console.WriteLine("y = " + p.PobierzY());
        Console.ReadKey();
    }
}
