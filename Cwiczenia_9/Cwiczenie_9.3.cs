using System;

public class Program
{
	public static void Main()
	{
		int a=-4;
		switch(a>=0)
		{
			case true:
				Console.WriteLine("|a|="+a);
				break;
			case false:
				Console.WriteLine("|a|="+(-a));
				break;
		}
		Console.ReadKey();
	}
}
