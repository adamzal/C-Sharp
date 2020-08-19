using System;

public class Program
{
	public static void Main()
	{
		int liczba=256;
		int lpomoc=liczba;
		Console.WriteLine(liczba>>=2);
		Console.WriteLine(lpomoc<<=2);
		Console.ReadKey();
	}
}
