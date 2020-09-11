using System;

class Outside
{
    public class Inside
    {       
        public void g()
        {
            Console.WriteLine("Inside.g()");
        }
    }
    public Inside getInside()
    {
        return new Inside();
    }
}

public class Program
{
    public static void Main()
    {
        new Outside().getInside().g();
        Console.ReadKey();
    }
}
