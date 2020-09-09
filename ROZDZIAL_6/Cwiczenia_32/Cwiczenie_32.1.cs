using System;

public interface IPierwszyInteface
{
    void f();
    void g();
}

public interface IDrugiInterface
{
    void g();
    void f();
}

public class Program:IPierwszyInteface,IDrugiInterface
{
    public void f() { }
    public void g() { }
}
