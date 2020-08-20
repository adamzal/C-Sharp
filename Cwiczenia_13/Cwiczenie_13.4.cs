using System;

public class Program
{
    public static void Main()
    {
        bool[,] tab = new bool[5, 8];
        int i, j;
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 8; j++)
            {
                tab[i,j] = i % 2 == 0 && j % 2 == 0 ? true : false;
            }
        }
        for (i = 0; i < 5; i++)
        {
            Console.Write("tab[{0}]= ", i);
            for (j = 0; j < 8; j++)
            {
                if (tab[i, j] == true)
                    Console.Write("1 ", i);
                else
                    Console.Write("0 ", i);
            }
    Console.WriteLine("");
                }
Console.ReadKey();
        }
}
