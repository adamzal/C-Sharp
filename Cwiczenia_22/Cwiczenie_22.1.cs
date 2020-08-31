using System;

public class Program
{
    public static void Main()
    {
        try
        {
            int liczba1 = 10, liczba2 = 0;
            liczba1 /= liczba2;
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(SystemException e)
        {
            Console.WriteLine(e.ToString());
        }
        Console.ReadKey();
    }
}
