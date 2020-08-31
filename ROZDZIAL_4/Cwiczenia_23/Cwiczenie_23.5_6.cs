using System;

public class NegativeValueException:Exception
{
    public NegativeValueException(string message = "Wartoś jest ujmena!") : base(message) { }
}

public class InvalidSinusValueException:Exception
{
    public InvalidSinusValueException(string message = "Wartość sinusalfa nie mieści się w zakresie <-1;1>!") : base(message) { }
}

class Punkt
{
    private double x;
    private double y;

    public double PobierzR()
    {
        return Math.Sqrt(x * x + y * y);
    }

    public void UstawR(double r)
    {
        if(r<0)
            throw new NegativeValueException();
        double sinusalfa = PobierzSinusalfa();

        x = r * Math.Sqrt(1 - sinusalfa * sinusalfa);
        y = r * sinusalfa;
    }

    public double PobierzSinusalfa()
    {
        return x == 0 && y == 0 ? 0 : y / Math.Sqrt(x * x + y * y);
    }

    public void UstawSinusalfa(double sinusalfa)
    {
        if (sinusalfa < -1 || sinusalfa > 1)
            throw new InvalidSinusValueException();
        double r = PobierzR();

        x = r * Math.Sqrt(1 - sinusalfa * sinusalfa);
        y = r * sinusalfa;
    }

    public void WyswietlWspolrzedne()
    {
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
    }

    public static void Main()
    {
        Punkt p = new Punkt();     
        try
        {
            p.UstawR(5);
            p.UstawSinusalfa(0.8);
            Console.WriteLine("r = " + p.PobierzR());
            Console.WriteLine("sina = " + p.PobierzSinusalfa());
            p.WyswietlWspolrzedne();
        }           
        catch (NegativeValueException e)
        {
            Console.WriteLine(e.Message);
        }               
        catch (InvalidSinusValueException e)
        {
            Console.WriteLine(e.Message);
        }        
        Console.ReadKey();
    }
}
