using System;

public class Program
{
	class Punkt
	{
		public int x;
		public int y;

		class Punkt3D : Punkt
		{
			public int z;

			public Punkt3D()
			{
				UstawXYZ(1, 1, 1);
			}

			public Punkt3D(int x, int y, int z)
			{
				UstawXYZ(x, y, z);
			}

			public Punkt3D(Punkt3D p)
			{
				UstawXYZ(p.x, p.y, p.z);
			}

			public void WypiszWspolrzedne()
			{
				Console.WriteLine("wspolrzedna x = " + x);
				Console.WriteLine("wspolrzedna y = " + y);
				Console.WriteLine("wspolrzedna z = " + z);
			}

			void UstawXYZ(int x,int y,int z)
            {
				this.x = x;
				this.y = y;
				this.z = z;
			}

			public static void Main()
			{
				Punkt3D p = new Punkt3D();
				p.WypiszWspolrzedne();

				Punkt3D q = new Punkt3D(10, 20, 30);
				q.WypiszWspolrzedne();

				Punkt3D r = new Punkt3D(q);
				r.WypiszWspolrzedne();

				Console.ReadKey();
			}
		}
	}
}
