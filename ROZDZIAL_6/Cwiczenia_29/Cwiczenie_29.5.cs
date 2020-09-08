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

public class Punkt3D : Punkt
{
    public int z;

    public Punkt3D(int x,int y,int z):base(x,y)
    {
        this.z = z;
    }

    public override string ToString()
    {
        return "x = " + x + "\ny = " + y + "\nz = " + z;
    }
}
public class Program
{
    public static void Main()
    {
        Punkt p1 = new Punkt(5,7);
        Punkt3D p2 = new Punkt3D(1, 2, 3);
        Console.WriteLine(p1+"\n");
        Console.WriteLine(p2 + "\n");
        Punkt p3 = (Punkt)p2;
        Console.WriteLine(p2 + "\n");
        Console.WriteLine(p3);
        Console.ReadKey();
    }
}
