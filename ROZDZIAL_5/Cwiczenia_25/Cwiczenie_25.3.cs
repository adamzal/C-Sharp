using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Wprowadzaj linie tesktu. Wpisz 'quit', aby zakończyć.");
        string line;
        do
        {
            line = Console.ReadLine();
            if (line != "quit")
                Console.WriteLine("Wprowadzona linia to: {0}", line);
        } while (line!="quit");
    }
}
