using System;

public class Program
{
	class Punkt
	{
		public int x;
		public int y;

		public Punkt()
	        {
			x = y = 1;
        	}

		public Punkt(int x,int y)
	        {
			this.x = x;
			this.y = y;
        	}	

		public Punkt(Punkt p)
	        {
			x = p.x;
			-y = p.y;
        	}

		class Punkt3D : Punkt
		{
			public int z;

			public Punkt3D():base()
			{
				z = 1;
			}

			public Punkt3D(int x, int y, int z):base(x,y)
			{
				this.z = z;
			}

			public Punkt3D(Punkt3D p):base (p)
			{
				z = p.z;
			}

			public Punkt3D(Punkt p):base(p)
            		{
				z = 100;
        		}

			public void WypiszWspolrzedne()
			{
				Console.WriteLine("wspolrzedna x = " + x);
				Console.WriteLine("wspolrzedna y = " + y);
				Console.WriteLine("wspolrzedna z = " + z);
			}

			public static void Main()
			{
				Punkt a = new Punkt();
				Punkt3D p = new Punkt3D();
				p.WypiszWspolrzedne();

				Punkt3D q = new Punkt3D(10, 20, 30);
				q.WypiszWspolrzedne();

				Punkt3D r = new Punkt3D(q);
				r.WypiszWspolrzedne();

				Punkt3D s = new Punkt3D(a);
				s.WypiszWspolrzedne();

				Console.ReadKey();
			}
		}
	}
}
