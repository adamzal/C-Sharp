using System;

public class Program
{
    static void f()
    {
        int[] tab = null;
        tab[1] = 1;
    }

    public static void Main()
    {
        try
        {
            f();
        }
        catch(NullReferenceException e)
        {
            Console.WriteLine("Wyjątek\t"+e.Message);
        }
        Console.ReadKey();
    }
}
