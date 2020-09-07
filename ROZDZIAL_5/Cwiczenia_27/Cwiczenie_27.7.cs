using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string plik = Console.ReadLine();
        string plik2 = Console.ReadLine();
        StreamReader sr;
        StreamWriter sw;
        try
        {
            sr = new StreamReader(new FileStream(plik,FileMode.Open));
            sw = new StreamWriter(new FileStream(plik2, FileMode.OpenOrCreate));
        }
        catch(Exception)
        {
            Console.WriteLine("Otwarcie pliku {0} nie powiodło się", plik);
            return;
        }
        try
        {
            string line = sr.ReadToEnd();
            int ile = line.Length;
            while(ile>0)
            {
                sw.Write(line[--ile]);
            }
        }
        catch(Exception)
        {
            Console.WriteLine("Zapis nie został dokonany");
            return;
        }
        sr.Close();
        sw.Close();
        Console.WriteLine("Zapis został dokonany");
        Console.ReadKey();
    }
}
