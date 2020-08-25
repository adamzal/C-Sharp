using System;

class Punkt
{
    private int x;
    private int y;

    public int PobierzX()
    {
        return x;
    }

    public int PobierzY()
    {
        return y;
    }

    public void UstawX(int x)
    {
        this.x = x;
    }

    public void UstawY(int y)
    {
        this.y = y;
    }

    public static void Main()
    {
        Punkt p = new Punkt();
        p.UstawX(100);
        p.UstawY(200);
        Console.WriteLine("x = " + p.PobierzX());
        Console.WriteLine("y = " + p.PobierzY());
        Console.ReadKey();
    }
}
