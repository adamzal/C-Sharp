using System;

class Punkt
{
    public int x;
    public int y;

    public void UstawXY(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void WyswietlWspolrzedne()
    {
        Console.WriteLine("wspolrzedna x = " + x);
        Console.WriteLine("wspolrzedna y = " + y);
    }
    class Punkt3D:Punkt
    {
        public int z;

        public void UstawXYZ(int x,int y,int z)
        {
            UstawXY(x, y);
            this.z = z;
        }

        public new void WyswietlWspolrzedne()
        {
            base.WyswietlWspolrzedne();
            Console.WriteLine("wspolrzedna z = " + z);
        }
    }

    public static void Main()
    {
        Punkt p = new Punkt();
        Punkt3D q = new Punkt3D();
        p.UstawXY(3, 4);
        q.UstawXYZ(3, 4, 5);
        p.WyswietlWspolrzedne();
        q.WyswietlWspolrzedne();
        Console.ReadKey();
    }
}
