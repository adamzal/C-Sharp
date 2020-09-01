using System;

public class Program
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] tablica = line.Split(new char[] { ',' });
        for(int i=0;i<tablica.Length;i++)
        {
            int liczba = Int32.Parse(tablica[i]);
            if(liczba%2==0)
            {
                Console.WriteLine(liczba);
            }
        }
        Console.ReadKey();
    }
}
