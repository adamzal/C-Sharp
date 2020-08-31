using System;

public class Punkt
{
    public int x;
    public int y;
}

public class Program
{
    public static void Main()
    {
        Punkt punkt = null;
        int liczba1 = 10, liczba2 = 0;
        try
        {            
            try
            {
                liczba1 /= liczba2;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Nieprawidłowa operacja arytmetyczna");
                Console.WriteLine(e.ToString());
            }
            punkt.x = liczba1;
        }
        catch(SystemException e)
        {
            Console.WriteLine("Błąd ogólny");
            Console.WriteLine(e.ToString());
        }
        Console.ReadKey();
    }
}
