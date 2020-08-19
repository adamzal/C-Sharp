using System;

public class Program
{
	public static void Main()
	{
		for(int i=1;i<=20;i++)
		{
			if(i%2==0)
				Console.Write("{0} ",i);
		}
		Console.ReadKey();
	}
}
