using System;

public class Program
{
    string metoda(int a,int b)
    {
        string msg = "";
        int[] p = new int[3];
        try
        {
            a /= b;
        }
        catch (ArithmeticException e)
        {
            msg += e.ToString();
        }
        try
        {
            p[a] = b;
        }
        catch(IndexOutOfRangeException e)
        {
            msg += e.ToString();
        }
        catch(Exception e)
        {
            msg += e.ToString();
        }
        return msg;
    }

    public static void Main()
    {
        Program p = new Program();
        Console.WriteLine(p.metoda(4,0));
        Console.ReadKey();
    }
}
