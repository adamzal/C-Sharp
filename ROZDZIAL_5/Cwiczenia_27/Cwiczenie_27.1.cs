using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string plik = Console.ReadLine();
        int ile = Convert.ToInt32(Console.ReadLine());
        byte[] dane = new byte[ile];
        for(int i=0;i<ile;i++)
        {
            if (i % 2 == 0)
                dane[i] = 127;
            else
                dane[i] = 255;
        }
        FileStream fs;
        try
        {
            fs = new FileStream(plik, FileMode.Create);
        }
        catch(Exception)
        {
            Console.WriteLine("Otwarcie pliku {0} nie powiodło się", plik);
            return;
        }

        try
        {
            fs.Write(dane, 0, ile);
        }
        catch(Exception)
        {
            Console.WriteLine("Zapis nie został dokonany");
            return;
        }
        fs.Close();
        Console.WriteLine("Zapis został dokonany");
        Console.ReadKey();
    }
}
