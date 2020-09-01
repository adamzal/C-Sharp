using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Proszę nacisnąć klawisz Q.\n");
        ConsoleKeyInfo keyInfo;
        do
        {
            keyInfo = Console.ReadKey();
            if (keyInfo.Key != ConsoleKey.Q)
                Console.WriteLine("\nTo nie jest klawisz Q. Naciśnij klawisz Q.");
        } while (keyInfo.Key != ConsoleKey.Q);
        Console.WriteLine("\nDziękuję za naciśnięcie klawisza Q.");
        Console.ReadKey();
    }
}
