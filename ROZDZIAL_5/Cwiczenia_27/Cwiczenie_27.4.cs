using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string plik = Console.ReadLine();        
        StreamReader sr;
        try
        {
            sr = new StreamReader(plik);
        }
        catch(Exception)
        {
            Console.WriteLine("Otwarcie pliku {0} nie powiodło się", plik);
            return;
        }
        try
        {
            Console.WriteLine(sr.ReadToEnd());
        }
        catch(Exception)
        {
            Console.WriteLine("Odczyt nie został dokonany");
            return;
        }
        sr.Close();
        Console.WriteLine("Odczyt został dokonany");
        Console.ReadKey();
    }
}
