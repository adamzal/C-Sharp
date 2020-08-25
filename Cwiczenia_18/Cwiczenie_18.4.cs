using System;

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
        double sinusalfa = PobierzSinusalfa();

        x = r * Math.Sqrt(1 - sinusalfa * sinusalfa);
        y = r * sinusalfa;
    }

    public double PobierzSinusalfa()
    {
       return x==0&&y==0? 0: y / Math.Sqrt(x * x + y * y);
    }

    public void UstawSinusalfa(double sinusalfa)
    {
        double r = PobierzR();

        x = r* Math.Sqrt(1 - sinusalfa * sinusalfa);
        y = r * sinusalfa;
    }

    public void WyswietlWspolrzedne()
    {
        Console.WriteLine("x = "+x);
        Console.WriteLine("y = " + y);
    }

    public static void Main()
    {
        Punkt p = new Punkt();
        p.UstawR(5.0);
        p.UstawSinusalfa(0.8);
        Console.WriteLine("r = " + p.PobierzR());
        Console.WriteLine("sina = " + p.PobierzSinusalfa());
        p.WyswietlWspolrzedne();
        Console.ReadKey();
    }
}
