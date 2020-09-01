using System;

public class Program
{
    public static void Main()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        while (keyInfo.Key!=ConsoleKey.Escape)
        {
            if(keyInfo.KeyChar>=97&&keyInfo.KeyChar<=122)
            {
                Console.WriteLine((char)(keyInfo.KeyChar+ 3));
            }
            keyInfo = Console.ReadKey(true);
        }
    }
}
