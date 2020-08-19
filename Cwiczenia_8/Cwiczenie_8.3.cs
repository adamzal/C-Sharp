using System;

public class Program
{
	public static void Main()
	{
		sbyte a=-4;
		if(a>=0)
		{
			Console.WriteLine("|a|= "+a);
		}
		else
		{
			Console.WriteLine("|a|= "+(-a));
		}
		Console.ReadKey();
	}
}
