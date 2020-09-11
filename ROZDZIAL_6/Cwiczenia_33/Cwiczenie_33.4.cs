using System;

public class Outside
{
  private int wartosc;
  public class Inside
  {
    private Outside parent;
    public Inside()
    {
      //pole parent niezainicjalizowane
    }
    public Inside(Outside obj)
    {
      parent = obj;
    }
    public void Ustaw(int val)
    {
      parent.wartosc = val;
    }
  }
  public void Wyswietl()
  {
    Console.WriteLine("Pole wartość = {0}", wartosc);
  }
}

public class Program
{
  public static void Main()
  {
    Outside out1 = new Outside();
    out1.Wyswietl();
    Outside.Inside ins1 = new Outside.Inside();
    ins1.Ustaw(100); //wyjątek NullReferenceException
    out1.Wyswietl();
    Console.ReadKey();
  }
}
