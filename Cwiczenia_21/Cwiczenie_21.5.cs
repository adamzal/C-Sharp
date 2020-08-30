using System;

public class Example
{
    private int[] tab = new int[1];
    public void a()
    {
        try
        {
            tab[2]=1;
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Wyjatek w metodzie a.");
        }
    }

    public void b()
    {
        try
        {
            a();
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Wyjatek w metodzie b.");
        }
    }

}

class Program
{
    public static void Main()
    {
        Example np = new Example();
        try
        {
            np.a();
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Wyjatek w metodzie Main a.");
        }
        try
        {
            np.b();
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Wyjatek w metodzie Main b.");
        }
        Console.ReadKey();
    }
}
