using System;

public class Program
{
	public static void Main()
	{
		int i=1;
		while(i<21)
		{
			if(i%3==0)
				Console.Write(i+"\t");
			i++;
		}
		Console.ReadKey();
	}
}
