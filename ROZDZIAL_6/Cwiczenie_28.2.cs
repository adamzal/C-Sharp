using System;

public class MojObiekt
{
    public override string ToString()
    {
        string kom = "Komunikat klasy nadrzędnej:\n";
        kom+= base.ToString()+"\n";
        kom += "Komunikat klasy podrzędnej:\n";
        return kom + "Jestem obiektem klasy MojObiekt";

    }
}

public class Program
{
    public static void Main()
    {
        MojObiekt mo = new MojObiekt();
        Console.WriteLine(mo);
        Console.ReadKey();
    }
}
