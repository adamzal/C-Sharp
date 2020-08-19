using System;

public class Program
{
	public static void Main()
	{
		int i=0;
		while(++i<21)
		{
			if(i%2==0)
				continue;
			Console.Write(i+"\t");
		}
		Console.ReadKey();
	}
}
