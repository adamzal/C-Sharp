using System;

public class Program
{
	public static void Main()
	{
		for(int i=1;i<11;i++)
		{
			if(i%2==0)
				Console.Write(i+"\t");
		}
		Console.ReadKey();
	}
}
