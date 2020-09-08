using System;
using System.Runtime.Remoting.Messaging;

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
        Punkt p = new Punkt();
        try
        {
            Punkt3D punkt3D = (Punkt3D)p;
            punkt3D.z = 10;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        Console.ReadKey();
    }
}
