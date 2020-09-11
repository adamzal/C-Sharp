using System;

public class Tablica<T>
{
    private T[] tab;
    public Tablica(int size)
    {
        if (size < 0)
        {
            throw new ArgumentOutOfRangeException("size < 0");
        }
        tab = new T[size];
    }
    public T Get(int index)
    {
        if (index >= tab.Length || index < 0)
        {
            throw new IndexOutOfRangeException("index = " + index);
        }
        else
        {
            return tab[index];
        }
    }
    public void Set(int index,T value)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("index = " + index);
        }
        if (index >= tab.Length)
        {
            Resize(index + 1);
        }
        tab[index] = value;
    }
    protected void Resize(int size)
    {
        T[] newTab = new T[size];
        for (int i = 0; i < tab.Length; i++)
        {
            newTab[i] = tab[i];
        }
        tab = newTab;
    }
    public int Length
    {
        get
        {
            return tab.Length;
        }
    }
}


class Triangle
{
    public string tri()
    {
        return "Triangle";
    }
}
class Rectangle
{
    public string rec()
    {
        return "Rectangle";
    }
}
class Circle
{
    public string cir()
    {
        return "Circle";
    }
}

public class Program
{
    public static void Main()
    {
        Tablica<Rectangle> rectangles = new Tablica<Rectangle>(3);
        Tablica<Triangle> triangles = new Tablica<Triangle>(3);
        Tablica<Circle> circles = new Tablica<Circle>(3);
        for (int i = 0; i < 5; i++)
        {
            rectangles.Set(i, new Rectangle());
            triangles.Set(i, new Triangle());
            circles.Set(i, new Circle());
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("---{0}---", i);
            Console.WriteLine(triangles.Get(i).tri());
            Console.WriteLine(rectangles.Get(i).rec());
            Console.WriteLine(circles.Get(i).cir());
        }
        Console.ReadKey();
    }
}
