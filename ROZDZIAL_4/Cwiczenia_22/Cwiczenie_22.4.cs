using System;

public class Program
{
    public static void Main()
    {
        int[] tab = new int[10];
        int liczba1 = 10, liczba2 = 0;
        string ex1 = null, ex2 = null;
        try
        {        
            try
            {
                liczba1 /= liczba2;
            }
            catch (ArithmeticException e)
            {
                ex1=e.ToString();
            }
            tab[10] = 1;
        }
        catch(IndexOutOfRangeException e)
        {
            ex2=e.ToString();
        }
        Console.WriteLine(ex2);
        Console.WriteLine(ex1);
        Console.ReadKey();
    }
}
