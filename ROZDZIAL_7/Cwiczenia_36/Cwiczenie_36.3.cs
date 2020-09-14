using System;

public delegate void DelegateWyswietl(Kontener obj);
public class Kontener
{    
    public int w1
    {
        get
        {
            return 100;
        }
    }
    public double w2
    {
        get
        {
            return 3.1415;
        }
    }
    public void wyswietlCallBack(DelegateWyswietl del)
    {
        del (this);
    }
}

public class Program
{
    public static void Wyswietlw1(Kontener obj) => Console.WriteLine("Wartość w1 to: {0}", obj.w1);
    public static void Wyswietlw2(Kontener obj) => Console.WriteLine("Wartość w2 to: {0}", obj.w2);

    public static void Main()
    {
        Kontener k=new Kontener();
        DelegateWyswietl del1 = Wyswietlw1;
        del1 += Wyswietlw2;
        k.wyswietlCallBack(del1);
        del1 -= Wyswietlw1;
        k.wyswietlCallBack(del1);
        Console.ReadKey();
    }
}
