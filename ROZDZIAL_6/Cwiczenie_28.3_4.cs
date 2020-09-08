using System;

public class Punkt
{
    public int x;
    public int y;
    public Punkt(int x,int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return "x = " + x + "\ny = " + y;
    }
}

public class Program
{
    public static void Main()
    {
        Punkt p = new Punkt(5,7);
        Console.WriteLine(p.ToString());
        Console.ReadKey();
    }
}
