using System;

public class Program
{
	public static void Main()
	{
		int i=0;
		int[] tab=new int[10];
		for(;i<10;i++)
		{
			tab[i]=101+i;
		}
		for(i=0;i<10;i++)
		{
			Console.WriteLine("tab[{0}]={1}",i,tab[i]);
		}
		Console.ReadKey();
	}
}
