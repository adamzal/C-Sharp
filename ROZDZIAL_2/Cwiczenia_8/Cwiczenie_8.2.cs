using System;

public class Program
{
	public static void Main()
	{
		int a=4;
		int b=5;
		int c=-1;
		if(b*b-4*a*c>=0)
		{
			Cosnole.WriteLine("Równanie kwadratowe ma rozwiązanie w zbiorze liczb rzeczywistych");
		}
		else
		{
			Console.WriteLine("Równanie kwadratowe nie ma rozwiązań w zbiorze liczb rzeczywistych");
		}
		Console.ReadKey();
	}
}
