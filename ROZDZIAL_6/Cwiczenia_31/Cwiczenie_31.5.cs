using System;

public interface IPunkt
{
    int x { get; set; }
    int y { get; set; }
}

public interface IPunkt3D:IPunkt
{
    int z { get; set; }
}

public class Punkt : IPunkt
{
    private int _x;
    private int _y;
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

public class Punkt3D:Punkt,IPunkt3D
{
    private int _z;
    public int z
    {
        get
        {
            return _z;
        }
        set
        {
            _z = value;
        }
    }
}
public class Program
{ 
    public static void Main()
    {
        Punkt3D punkt3D1 = new Punkt3D();

        punkt3D1.x = 10;
        punkt3D1.y = 20;
        punkt3D1.z = 30;

        Console.WriteLine("punkt3D1");
        Console.WriteLine("x = " + punkt3D1.x);
        Console.WriteLine("y = " + punkt3D1.y);
        Console.WriteLine("z = " + punkt3D1.z);
        Console.WriteLine("");

        Punkt punkt1 = (Punkt)punkt3D1;

        Console.WriteLine("punkt1");
        Console.WriteLine("x = " + punkt1.x);
        Console.WriteLine("y = " + punkt1.y);
        Console.WriteLine("");

        Punkt3D punkt3D2 = (Punkt3D)punkt1;

        Console.WriteLine("punkt3D2");
        Console.WriteLine("x = " + punkt3D2.x);
        Console.WriteLine("y = " + punkt3D2.y);
        Console.WriteLine("z = " + punkt3D2.z);
        Console.ReadKey();
    }
}
