using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string kat = Console.ReadLine();
        string wzorzec = Console.ReadLine();
        DirectoryInfo di;
        di = new DirectoryInfo(kat);
        DirectoryInfo[] katalogi = di.GetDirectories(wzorzec);        
        foreach(DirectoryInfo katalog in katalogi)
        {
            Console.WriteLine(katalog.Name);
        }
        Console.ReadKey();
    }
}
