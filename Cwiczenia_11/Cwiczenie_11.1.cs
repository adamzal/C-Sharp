using System;

public class Program
{
	public static void Main()
	{
		for(int i=1;i<21;i++)
		{
			if(i%2==0)
				continue;
			Console.Write(i+"\t");
		}
		Console.ReadKey();
	}
}
