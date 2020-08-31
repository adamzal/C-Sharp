using System;

public class Program
{
    public static string metoda(string napis)
    {
        string wynik="";
        char litera = '\0';
        for(int i=0;i<napis.Length;i++)
        {
            if((napis[i]=='a'||napis[i]=='b'||napis[i]=='c')&&(litera!='k'&&litera!='l'&&litera!='j'))
            {
                wynik += ' ';
            }
            else
            {
                wynik += napis[i];                
            }
            litera = napis[i];
        }
        return wynik;
    }
    public static void Main()
    {
        Console.WriteLine(metoda("aksjomat"));
        Console.WriteLine(metoda("black"));
        Console.WriteLine(metoda("kabjcl"));
        Console.ReadKey();
    }
}
