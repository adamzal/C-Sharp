using System;

public class Program
{
	public static void Main()
	{
		int liczba = 10;
		int liczba2;
		if(liczba<0)
			liczba2=-1;
		else
			liczba2=1;
		Console.WriteLine(liczba2);
		Console.ReadKey();
	}
}
