using System;

public class Program
{
	public static void Main()
	{
		int i=0;
		do
		{
			Console.WriteLine("[i={0}] Pętle w C#",i);
		}
		while(++i<=9);
		Console.ReadKey();
	}
}
