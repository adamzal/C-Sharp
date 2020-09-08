using System;
using System.Runtime.Remoting.Messaging;

public class ParentShape
{
    public virtual void Draw()
    {
        Console.WriteLine("Zostałem stworzony.");
    }
}
public class Shape:ParentShape
{
    public override void Draw()
    {
        Console.WriteLine("Jestem jakimś kształtem.");
    }    
}

public class Circle:Shape
{
    public override void Draw()
    {
        Console.WriteLine("Jestem kołem.");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Jestem prostokątem.");
    }
}

public class Triangle : Shape
{
}
public class Program
{
    public static void DrawShape(ParentShape ps)
    {
        ps.Draw();
    }
    public static void Main()
    {
        Circle circle = new Circle();
        Rectangle rect = new Rectangle();
        Triangle tri = new Triangle();
        DrawShape(circle);
        DrawShape(rect);
        DrawShape(tri);
        Console.ReadKey();
    }
}
