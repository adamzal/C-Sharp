using System;

public class Program
{
    public static void Main()
    {
        int[] tab = new int[2];
        try
        {
            try
            {
                tab[2]=2;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Wyjątek 1");
                throw e;
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Wyjątek 2");
            throw e;
        }
        Console.ReadKey();
    }
}
