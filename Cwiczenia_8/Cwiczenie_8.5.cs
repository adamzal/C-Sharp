using System;

public class Program
{
	public static void Main()
	{
		int lupx=-4;
		int lupy=3;
		int width=7;
		int height=3;
		int px=-3;
		int py=1;
		if(px>=lupx&&px<=lupx+width&&py<=lupy&&py>=lupy-height)
		{
			Console.WriteLine("Podany punkt zawiera się w prostokącie.");
		}
		else
		{
			Console.WriteLine("Podany punkt nie zawiera się w prostokącie.");
		}
		Console.ReadKey();
	}
}
