using System;

class Punkt
{
	public int x;
	public int y;

	public int PobierzX()
	{
		return x;
	}

	public int PobierzY()
	{
		return y;
	}

	public void UstawX(int x)
	{
		this.x=x;
	}

	public void UstawY(int y)
	{
		this.y=y;
	}

	public void UstawXY(int x,int y)
	{
		this.x=x;
		this.y=y;
	}

	public void WyswietlWspolrzedne()
	{
		Console.WriteLine("współrzędna x = "+x);
		Console.WriteLine("współrzędna y = "+y);
	}

	class Punkt3D : Punkt
	{
		public int z;
	}
}
