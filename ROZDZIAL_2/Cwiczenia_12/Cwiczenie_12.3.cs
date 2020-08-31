using System;

public class Program
{
	public static void Main()
	{
		bool[] tab=new bool[20];
		int i=0;
		for(;i<20;i++)
		{
			tab[i]= i%2==0?true:false;
		}
		for(i=0;i<20;i++)
		{
			Console.WriteLine("tab[{0}]={1}",i,tab[i]);
		}
		Console.ReadKey();
	}
}
