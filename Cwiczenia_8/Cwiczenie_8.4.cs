using System;

public class Program
{
	public static void Main()
	{
		int p1x=3;
		int p1y=4;
		int p2x=-3;
		int p2y=4;
		if(p1x==p2x)
		{
			Console.WriteLine("Prosta przechodząca przez te punkty jest równoległa do osi Oy");
		}
		if(p1y==p2y)
		{
			Console.WriteLine("Prosta przechodząca przez te punkty jest równoległa do osi Ox");
		}
		Console.ReadKey();
	}
}
