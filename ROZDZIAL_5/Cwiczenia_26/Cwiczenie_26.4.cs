using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string name = Console.ReadLine();
        DirectoryInfo di = new DirectoryInfo(name);
        if (di.Exists)
        {
            Console.WriteLine("Podany katalog istnieje\n Czy chcesz usunąć katalog? Wpisz tak lub nie.");
            if (Console.ReadLine() == "tak")
            {
                di.Delete();
                Console.WriteLine("Katalog {0} został usunięty", name);
            }
        }
        FileInfo fi = new FileInfo(name);
        if (fi.Exists)
        {
            Console.WriteLine("Podany plik istnieje\n Czy chcesz usunąć plik? Wpisz tak lub nie.");
            if (Console.ReadLine() == "tak")
            {
                fi.Delete();
                Console.WriteLine("Plik {0} został usunięty", name);
            }
        }
        Console.ReadKey();
    }
}
