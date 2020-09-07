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
        int a = 0;
        string line = sr.ReadLine();
        try
        {
            while(line!=null)
            {
                if (a % 2 == 0)
                    Console.WriteLine(line);
                a++;
                line = sr.ReadLine();
            }
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
