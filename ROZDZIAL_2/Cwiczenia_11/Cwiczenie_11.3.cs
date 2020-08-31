using System;

public class Program
{
	public static void Main()
	{
		int i=100;
		for(;i>0;i--)
		{
			if(i%3==0||i%4==0)
				continue;
			Console.Write(i+"\t");
		}
		Console.WriteLine("");
		i=100;
		for(;i>0;i--)
		{
			if(i%3!=0&&i%4!=0)
				Console.Write(i+"\t");
		}
		Console.ReadKey();
	}
}

