using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string plik = Console.ReadLine();        
        FileStream fs;
        try
        {
            fs = new FileStream(plik, FileMode.Open);
        }
        catch(Exception)
        {
            Console.WriteLine("Otwarcie pliku {0} nie powiodło się", plik);
            return;
        }
        int b;
        try
        {
            while((b=fs.ReadByte())!=-1)
            {
                Console.WriteLine(b);
            }
        }
        catch(Exception)
        {
            Console.WriteLine("Odczyt nie został dokonany");
            return;
        }
        fs.Close();
        Console.WriteLine("Odczyt został dokonany");
        Console.ReadKey();
    }
}
