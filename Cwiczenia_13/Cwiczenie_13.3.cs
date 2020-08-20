using System;

public class Program
{
	public static void Main()
	{
		int l=10;
		int i,j;
		int[][] tab=new int[4][];
		for(i=0;i<4;i++)
		{
			tab[i]=new int[i+1];
		}
		for(i=0;i<tab.Length;i++)
		{
			for(j=0;j<tab[i].Length;j++)
			{
				tab[i][j]=l--;
			}
		}
		for(i=0;i<tab.Length;i++)
		{
			Console.Write("tab[{0}]= ",i);
			for(j=0;j<tab[i].Length;j++)
			{
				Console.Write("{0} ",tab[i][j]);
			}
			Console.WriteLine();
		}
		Console.ReadKey();
	}
}
