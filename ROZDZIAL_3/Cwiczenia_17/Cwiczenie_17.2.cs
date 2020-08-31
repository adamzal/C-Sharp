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
		this.x = x;
	}

	public void UstawY(int y)
	{
		this.y = y;
	}

	public void UstawXY(int x, int y)
	{
		this.x = x;
		this.y = y;
	}

	public void WyswietlWspolrzedne()
	{
		Console.WriteLine("współrzędna x = " + x);
		Console.WriteLine("współrzędna y = " + y);
	}

	class Punkt3D : Punkt
	{
		public int z;
	}

	public void UstawZ(int z)
    {
		this.z = z;
    }

	public void UstawXZ(int x,int z)
    {
		this.x = x;
		this.z = z;
    }

	public void UstawXZ(int y, int z)
	{
		this.y = y;
		this.z = z;
	}

	public int PobierzZ()
    {
		return z;
    }

	public void UstawXYZ(int x, int y, int z)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}
}

