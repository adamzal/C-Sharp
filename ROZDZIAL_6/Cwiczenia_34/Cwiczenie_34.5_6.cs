using System;

public class dane<T>
{
    private T _var;
    public dane(T v)
    {
        _var = v;
    }
    public T var
    {
        get
        {
            return _var;
        }
        set
        {
            _var = value;
        }
    }
    public string Show()
    {
        return _var.ToString();
    }
}

public class Program
{
    public static void Main()
    {
        dane<int> a = new dane<int>(496);
        Console.WriteLine(a.Show());        
        dane<string> b = new dane<string>("napis");
        Console.WriteLine(b.Show());
        Console.ReadKey();
    }
}
