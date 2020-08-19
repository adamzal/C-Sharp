using System;

public class Program
{
	public static void Main()
	{
		int i=-100;
		for(;i<101;i++)
		{
			if(i%8==0||i%10==0)
				continue;
			if(i%4==0)
				Console.Write(i+"\t");
		}
		Console.ReadKey();
	}
}
