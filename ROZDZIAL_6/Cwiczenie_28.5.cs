using System;

public class Punkt
{
    public int x;
    public int y;  
}

public class Punkt3D : Punkt
{
    public int z;
}
public class Program
{
    public static void Main()
    {
        Punkt p = new Punkt3D();
        ((Punkt3D)p).z = 10;
        Console.ReadKey();
    }
}
