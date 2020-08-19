using System;

public class Program
{
	public static void Main()
	{
		int j=0;
		for(;j<21;j++)
		{
			int i=20;
			for(i-=j;i>0;i--)
			{
				Console.Write(i+" ");
			}
			Console.WriteLine("");
		}
		Console.ReadKey();
	}
}
