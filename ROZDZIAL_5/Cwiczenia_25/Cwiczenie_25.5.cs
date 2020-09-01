using System;

public class FunkcjaKwadratowa
{
    static double wsp()
    {
        double a = 0;
        bool format = false;
        do
        {
            format = false;
            try
            {
                a = Double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wprowadzona wartość nie jest prawidłowa.");
                format = true;
            }
        } while (format);
        return a;
    }   

    public void mZerowe(double a,double b,double c)
    {
        if (delta(a, b, c) > 0)        
            Console.WriteLine("Funkcja posiada dwa pierwiastki (miejsca zerowe) x1 i x2. Gdzie x1 = {0}\t x2 = {1}", x1(a, b, c), x2(a, b, c));      
        if (delta(a, b, c) == 0)        
            Console.WriteLine("Funkcja posiada pierwiastek podwójny x0 = {0}", x1(a, b, c));        
        if (delta(a, b, c) < 0)
            Console.WriteLine("Funkcja nie posiada miejsc zerowych.");
    }
    static double x1(double a, double b, double c) => (-b - Math.Sqrt(delta(a, b, c))) / (2 * a);

    static double x2(double a, double b, double c) => (-b + Math.Sqrt(delta(a, b, c))) / (2 * a);

    static double delta(double a, double b, double c) => b * b - 4 * a * c;
    public static void Main()
    {
        FunkcjaKwadratowa fk = new FunkcjaKwadratowa();
        double a,b,c;
        Console.WriteLine("Wprowadź współczynnik a:");
        a = FunkcjaKwadratowa.wsp();
        if(a==0)
        {
            Console.WriteLine("Równanie nie jest równaniem kwadratowym.");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Wprowadź współczynnik b:");
        b = FunkcjaKwadratowa.wsp();
        Console.WriteLine("Wprowadź współczynnik c:");
        c = FunkcjaKwadratowa.wsp();
        fk.mZerowe(a, b, c);
        Console.ReadKey();
    }
}
