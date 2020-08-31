using System;

class Program
{
    double liczba;
    char znak;
    Program(double liczba)
    {
        this.liczba = liczba;
    }

    Program(char znak)
    {
        this.znak=znak;
    }

    Program(double liczba,char znak):this(liczba)
    {
        //this.liczba = liczba;
        this.znak = znak;
    }

    Program(char znak,double liczba):this(znak)
    {
        this.liczba = liczba;
        //this.znak = znak;
    }

    public static void Main()
    {
        Program q = new Program(4);
        Program w = new Program('a');
        Program e = new Program(5,'b');
        Program r = new Program('c',6);
        Console.WriteLine(q.liczba);
        Console.WriteLine(w.znak);
        Console.Write(e.liczba);
        Console.Write(e.znak+"\n");
        Console.Write(r.znak);
        Console.Write(r.liczba+"\n");
        Console.ReadKey();
    }
}
