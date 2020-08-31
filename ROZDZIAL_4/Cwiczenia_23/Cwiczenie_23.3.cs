using System;

public class NegativeValueException : Exception
{
    public NegativeValueException(string message="Zwrócono ujemny wynik"):base(message)
    {    
    }
}
public class Program
{
    public static int Odejmij(int a, int b)
    {
        if (a - b < 0)
            throw new NegativeValueException();
        return a - b;
    }
    public static void Main()
    {
        try
        {
            Console.WriteLine(Odejmij(3, 13));
        }
        catch(NegativeValueException e)
        {
            Console.WriteLine(e.Message);
        }        
        Console.ReadKey();
    }
}
