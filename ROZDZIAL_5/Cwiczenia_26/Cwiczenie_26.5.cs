using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        long size=0;
        string name = Console.ReadLine();
        DirectoryInfo di = new DirectoryInfo(name);
        FileInfo[] fi = di.GetFiles();
        foreach(FileInfo fis in fi)
        {
            size += fis.Length;
        }
        Console.WriteLine(size);
        Console.ReadKey();
    }
}
