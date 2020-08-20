using System;

public class Program
{
	public static void Main()
	{
		int[][] tab=new int[4][];
		tab[0]=new int[4];
		tab[1]=new int[3];
		tab[2]=new int[2];
		tab[3]=new int[1];

		int licznik=1;
		int i=0,j;
		while(i<tab.Length)
		{
			j=0;
			while(j<tab[i].Length)
			{
				tab[i][j]=licznik++;
				j++;
			}
			i++;
		}
		i=0;
		while(i<tab.Length)
		{
			j=0;
			Console.Write("tab[{0}]= ",i);
			while(j<tab[i].Length)
			{
				Console.Write("{0} ",tab[i][j]);
				j++;
			}
			i++;
			Console.WriteLine("");
		}
		Console.ReadKey();
	}
}
