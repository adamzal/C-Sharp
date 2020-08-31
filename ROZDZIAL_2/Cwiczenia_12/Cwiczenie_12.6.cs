using System;

public class Program
{
	public static void Main()
	{
		int[] tab=new int[10];
		int i=0;
		while(i<tab.Length)
		{
			tab[i]=i;
			i++;
		}
		i=0;
		while(i<tab.Length)
		{
			Console.WriteLine("tab[{0}]={1}",i,tab[i]);
			i++;
		}
		Console.ReadKey();
	}
}
