using System;

public class Program
{
	public static void Main()
	{
		int i=0;
		int[] tab=new int[10];
		for(;i<10;i++)
		{
			tab[i]=i*10+10;
		}
		for(i=0;i<10;i++)
		{
			Console.WriteLine("tab[{0}]={1}",i,tab[i]);
		}
		Console.ReadKey();
	}
}
