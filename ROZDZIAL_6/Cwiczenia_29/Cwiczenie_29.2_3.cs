using System;

public class Glowna
{
    public override string ToString()
    {
        return "Jestem obiektem klasy Glowna";
    }
}

public class Pochodna:Glowna
{
    public override string ToString()
    {
        return "Jestem obiektem klasy Pochodna";
    }
}
public class Program
{
    public static void Main()
    {
        Glowna g = new Glowna();
        Pochodna p = new Pochodna();
        Console.WriteLine(g.ToString());
        Console.WriteLine(p.ToString());
        Glowna g2 = (Glowna)p;
        Console.WriteLine(g2.ToString());
        Console.ReadKey();
    }
}
