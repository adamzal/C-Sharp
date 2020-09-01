using System;

public class Program
{
    static int funk()
    {
        int a=0;
        bool format = false;
        do
        {
            format = false;
            try
            {
                a = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wprowadzona wartość nie jest prawidłowa.");
                format = true;
            }
        } while (format);
        return a;
    }
    public static void Main()
    {
        int a,b;
        a = Program.funk();
        b = Program.funk();        
        Console.WriteLine(a * b);
        Console.ReadKey();
    }
}
