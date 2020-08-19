using System;

public class Program
{
	public static void Main()
	{
		int a=32;
		int b=190;
		a+=b;
		b=a-b;
		a-=b;
		Console.WriteLine("Liczba a: "+a+"\nLiczba b: "+b);
		Console.ReadKey();
	}
}
