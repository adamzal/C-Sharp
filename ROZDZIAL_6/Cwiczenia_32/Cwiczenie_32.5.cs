using System;

public interface IFirstInreface
{
    void f(int a);
    void f();
}

public interface ISecondInterface
{
    int f(double a);
    void f();
}

public class Telewizor:IFirstInreface,ISecondInterface
{
    public void f()
    {
        Console.WriteLine("Metoda f");
    }
    public void f(int argument)
    {
        Console.WriteLine("f:argument = " + argument);
    }
    public int f(double argument)
    {
        Console.WriteLine("f:argument = " + argument);
        return (int)argument;
    }
}
