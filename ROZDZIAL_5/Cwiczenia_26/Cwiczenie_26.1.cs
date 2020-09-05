using System;
using System.IO;

public class Program
{
    public static void Main()
    {       
        DirectoryInfo di;
        di = new DirectoryInfo(".");
        DirectoryInfo[] katalogi = di.GetDirectories();        
        Console.WriteLine(di.Name);
        Console.WriteLine(di.Parent);
        Console.WriteLine(di.CreationTime);
        Console.WriteLine(di.CreationTimeUtc);
        Console.WriteLine(di.Attributes);
        Console.WriteLine(di.FullName);
        Console.WriteLine(di.LastAccessTime);
        Console.WriteLine(di.LastAccessTimeUtc);
        Console.WriteLine(di.LastWriteTime);
        Console.WriteLine(di.LastWriteTimeUtc);
        Console.ReadKey();
    }
}
