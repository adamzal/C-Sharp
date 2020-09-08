using System;

public abstract class First
{
    public abstract void f();
}

public abstract class Second:First
{
    public abstract void g();
}

public class Third:Second
{
    public override void f()
    {
    }
    public override void g()
    {
    }
}
