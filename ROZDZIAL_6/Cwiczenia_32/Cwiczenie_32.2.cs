using System;

public interface IPierwszyInteface
{
    void f(int a);
}

public interface IDrugiInterface
{
    void g(double a);
}

public class Program:IPierwszyInteface,IDrugiInterface
{
    public void f(int a) { }
    public void g(double b) { }
}
