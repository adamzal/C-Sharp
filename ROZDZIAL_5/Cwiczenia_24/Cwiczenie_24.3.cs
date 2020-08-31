using System;

public class Program
{ 
    public static void Main()
    {
        int pom = 0;
        string napis = "przykładowy napis";
        for(int i=napis.Length-1;i>=0;i--)
        {
            Console.Write(napis[i]);
            if (pom++ >=1)
            {
                Console.WriteLine("");
                pom = 0;
            }                                 
        }
        Console.ReadKey();
    }
}    
