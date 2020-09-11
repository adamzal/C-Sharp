using System;

public class Tablica
{
    private Object[] tab;
    public Tablica(int size)
    {
        if (size < 0)
        {
            throw new ArgumentOutOfRangeException("size < 0");
        }
        tab = new Object[size];
    }
    public Object Get(int index)
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
    public void Set(int index, Object value)
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
        Object[] newTab = new Object[size];
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


class Triangle { }
class Rectangle
{
    public void Diagonal() { }
}

public class Program
{
    public static void Main()
    {
        Tablica rectangle = new Tablica(3);
        rectangle.Set(0, new Rectangle());
        rectangle.Set(1, new Rectangle());
        rectangle.Set(2, new Triangle());
        for(int i=0;i<rectangle.Length;i++)
        {
            if (rectangle.Get(i) is Rectangle)
                ((Rectangle)rectangle.Get(i)).Diagonal();
        }
	Console.ReadKey();
    }
}
