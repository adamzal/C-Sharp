using System;

class Punkt
{
	int x;
	int y;

	int PobierzX()
	{
		return x;
	}

	int PobierzY()
	{
		return y;
	}

	void UstawX(int wspX)
	{
		x=wspX;
	}

	void UstawX(Punkt p)
	{
		x=p.x;
	}

	void UstawY(int wspY)
	{
		y=wspY;
	}

	void UstawY(Punkt p)
	{
		y=p.y;
	}

	void UstawXY(int wspX, int wspY)
	{
		x=wspX;
		y=wspY;
	}

	void WyswietlWspolrzedne()
	{
		Console.WriteLine("współrzędna x = "+x);
		Console.WriteLine("współrzędna y = "+y);
	}

	public static void Main()
	{
		Punkt pierwszyPunkt = new Punkt();
		Punkt drugiPunkt = new Punkt();

		pierwszyPunkt.UstawX(100);
		pierwszyPunkt.UstawY(100);

		Console.WriteLine("pierwszyPunkt:");
		pierwszyPunkt.WyswietlWspolrzedne();

		drugiPunkt.UstawX(pierwszyPunkt);
		drugiPunkt.UstawY(pierwszyPunkt);

		Console.WriteLine("\ndrugiPunkt:");
		drugiPunkt.WyswietlWspolrzedne();
		Console.ReadKey();
	}
}
