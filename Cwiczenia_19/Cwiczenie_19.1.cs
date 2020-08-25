using System;

class Punkt
{
    private double x;
    private double y;

    public void UstawXY(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public double odleglosc()
    {
        return Math.Sqrt(x * x + y * y);
    }
    class Punkt3D:Punkt
    {
        private double z;

        public void UstawXYZ(int x,int y,int z)
        {
            UstawXY(x, y);
            this.z = z;
        }
        public new double odleglosc()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }
    public static void Main()
    {
        Punkt p = new Punkt();
        Punkt3D q = new Punkt3D();
        p.UstawXY(3, 4);
        q.UstawXYZ(3, 4, 5);
        Console.WriteLine(p.odleglosc());
        Console.WriteLine(q.odleglosc());
        Console.ReadKey();
    }
}
