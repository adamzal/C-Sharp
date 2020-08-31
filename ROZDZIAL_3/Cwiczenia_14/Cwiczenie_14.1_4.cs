using System;

class LiczbaCalkowita
{
	int x;
	void WyswietlLiczbe()
	{
		Console.WriteLine("Liczba = "+x);
	}

	int PobierzLiczbe()
	{
		return x;
	}

	public static void Main()
	{
		LiczbaCalkowita LICZBA = new LiczbaCalkowita();
		LICZBA.x=-17;
		LICZBA.WyswietlLiczbe();
		Console.WriteLine(LICZBA.PobierzLiczbe());
		Console.ReadKey();
	}
}
