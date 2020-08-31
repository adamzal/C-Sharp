using System;

public class Program
{
    public static void Main()
    {
        string alfabet = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUWXYZ";
        for(int i=0;i<alfabet.Length;i++)
        {
            Console.WriteLine("{0} posiada kod \\x{1,-4:X4}", alfabet[i], (int)alfabet[i]);
        }
        Console.ReadKey();
    }
}    
