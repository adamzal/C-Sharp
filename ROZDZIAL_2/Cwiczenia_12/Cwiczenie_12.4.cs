using System;

public class Program
{
	public static void Main()
	{
		int i=0;
		int j=0;
		int[] tab=new int[100];
		for(;i<100;i++)
		{
			if(i%10==0)
				j=0;
			tab[i]=j;
			j++;
		}
		for(i=0;i<100;i++)
		{
			Console.WriteLine("tab[{0}]={1}",i,tab[i]);
		}
		Console.ReadKey();
	}
}
			
