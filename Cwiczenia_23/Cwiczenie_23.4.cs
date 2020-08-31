using System;

public class GeneralException:Exception
{
    public GeneralException(string message):base(message)
    {
    }
}
public class Program
{
    public static void Main()
    {
        try
        {
            throw new GeneralException("komunikat");
        }
        catch(GeneralException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadKey();
    }
}
