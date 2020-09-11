using System;

public class TablicaInt
{
    private int[] tab;
    public TablicaInt(int size)
    {
        if (size < 0)
        {
            throw new ArgumentOutOfRangeException("size<0");
        }
        tab = new int[size];
    }

    public int Get(int index)
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

    public void Set(int index, int value)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("index = " + index);
        }
        if (index >= tab.Length)
        {
            Resize((index + 1)*2);
        }
        tab[index] = value;
    }

    protected void Resize(int size)
    {
        int[] newTab = new int[size];
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
