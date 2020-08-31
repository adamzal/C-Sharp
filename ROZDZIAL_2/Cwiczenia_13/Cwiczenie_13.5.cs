using System;

public class Program
{
    public static void Main()
    {
        int i, j, k, l = 24;
        int[][][] tab= new int[2][][];
        for (i = 0; i < 2; i++)
        {
            tab[i] = new int[3][];
            for (j = 0; j < 3; j++)
            { 
                tab[i][j] = new int[4];
            }
        }
        for (i = 0; i < tab.Length; i++)
        {
            for (j = 0; j < tab[i].Length; j++)
            {
                for (k=0;k<tab[i][j].Length;k++)
                {
                	tab[i][j][k]=l--;
                }
	    }
	}
        for(i=0;i<tab.Length;i++)
        {
        	for(j=0;j<tab[i].Length;j++)
                {
               		for(k=0;k<tab[i][j].Length;k++)
                        {
                        	Console.Write("tab[{0}][{1}][{2}]= {3}\t",i,j,k,tab[i][j][k]);
                        }
			Console.WriteLine("");
               	}
                Console.WriteLine("");
        }
        Console.ReadKey();
    }
}
