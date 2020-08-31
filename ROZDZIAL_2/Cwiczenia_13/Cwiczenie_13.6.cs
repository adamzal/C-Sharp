using System;


public class Program
{
    public static void Main()
    {
        int i, j, a0 = 1, a1 = 1,a;
        int[][] tab = new int[10][];
        tab[0] = new int[a0];
        tab[1] = new int[a1];
        for (i = 2; i < tab.Length; i++)
        {
            a = a0 + a1;
            tab[i] = new int[a];
            a0 = a1;    
            a1 = a;
        }
        for (i = 0; i < tab.Length; i++)
        {
            for (j = 0; j < tab[i].Length; j++)
            {
                tab[i][j] = tab[i].Length - j;
            }
        }

        for (i = 0; i < tab.Length; i++)
        {
            Console.Write("tab[{0}]= ", i);
            for (j = 0; j < tab[i].Length; j++)
            {
                Console.Write("{0} ", tab[i][j]);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
