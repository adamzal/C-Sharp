using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string plik = Console.ReadLine();
        int ile = Convert.ToInt32(Console.ReadLine());
        byte[] dane = new byte[ile];
        int i = 0;
        while (i<ile)
        {
            dane[i] = Convert.ToByte(Console.ReadLine());
            i++;
        }
        BinaryWriter sr;
        try
        {
            sr = new BinaryWriter(new FileStream(plik,FileMode.Open));
        }
        catch(Exception)
        {
            Console.WriteLine("Otwarcie pliku {0} nie powiodło się", plik);
            return;
        }
        try
        {
            for(i=0;i<ile;i++)
            {
                sr.Write(dane[i]+"\n");
            }
        }
        catch(Exception)
        {
            Console.WriteLine("Zapis nie został dokonany");
            return;
        }
        sr.Close();
        Console.WriteLine("Zapis został dokonany");
        Console.ReadKey();
    }
}
