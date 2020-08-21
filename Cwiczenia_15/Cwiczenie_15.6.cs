using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Cwiczenie_15.4.cs");
		D1.Dzialania d1 = new D1.Dzialania();
		d1.Dodaj(30,40);
		Console.WriteLine("Wynik = "+d1.wynik);
		d1.Odejmij(15,7);
		Console.WriteLine("Wynik = "+d1.wynik+"\n");

		Console.WriteLine("Cwiczenie_15.5.cs");
		int l1=37,l2=17;
		D2.Dzialania d2= new D2.Dzialania();
		d2.Dodaj(ref l1,l2);
		Console.WriteLien("Wynik = "+d2.wynik);
		Console.WriteLine("Zmienna l1 = "+l1);
                d2.Odejmij(ref l1,l2);
                Console.WriteLien("Wynik = "+d2.wynik);
                Console.WriteLine("Zmienna l1 = "+l1);
		Console.ReadKey();
		Console.ReadKey();
	}
}
