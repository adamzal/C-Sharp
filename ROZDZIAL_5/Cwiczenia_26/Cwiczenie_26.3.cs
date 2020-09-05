using System;
using System.IO;

public class Program
{
    public static void Main()
    {        
        DirectoryInfo di;
        di = new DirectoryInfo(".");
        FileSystemInfo[] fi=di.GetFileSystemInfos();     
        foreach(FileSystemInfo fis in fi)
        {
            Console.WriteLine(fis.Name);
        }
        Console.ReadKey();
    }
}
