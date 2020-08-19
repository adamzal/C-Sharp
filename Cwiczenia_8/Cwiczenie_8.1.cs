using System;

public class Program
{
	public static void Main()
	{
		int a=17;
		int b=31;
		if(a%b==0)
		{
			Console.WriteLine("Reszta z dzielenia a/b jest równa 0.");
		}
		else
		{
			Console.WriteLine("Reszta z dzielenia a/b jest różna od 0.");
		}
		Console.ReadKey();
	}
}
