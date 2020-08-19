using System;

public class Program
{
	public static void Main()
	{
		int a=17;
		int b=71;
		Console.WriteLine(a^b^b);
		Console.WriteLine(a^=b);
		Console.ReadKey();
	}
}
