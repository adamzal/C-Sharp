using System;
using System.IO;

public class Glowna
{
}

public class Pochodna:Glowna
{
}
public class Program
{
    public static void Main()
    {
        Pochodna p1 = new Pochodna();
        Glowna g1 = p1;
        Pochodna p2 = (Pochodna) g1;
        Console.ReadKey();
    }
}
