using System;

public class Program
{
	class Punkt
	{
		public int x;
		public int y;

		void UstawXY(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		class KolorowyPunkt : Punkt
		{
			public int kolor;

			public KolorowyPunkt()
			{
				UstawXY(1, 1);
				UstawKolor(1);
			}

			public KolorowyPunkt(int x, int y, int kolor)
			{
				UstawXY(x, y);
				UstawKolor(kolor);
			}

			public KolorowyPunkt(KolorowyPunkt p)
			{
				UstawXY(p.x, p.y);
				UstawKolor(p.kolor);
			}

			void UstawKolor(int kolor)
			{
				this.kolor = kolor;
			}

			int PobierzKolor()
			{
				return kolor;
			}

			public void Wypisz()
			{
				Console.WriteLine("wspolrzedna x = " + x);
				Console.WriteLine("wspolrzedna y = " + y);
				Console.WriteLine("kolor = " + kolor);
			}

			public static void Main()
			{
				KolorowyPunkt p = new KolorowyPunkt();
				p.Wypisz();

				KolorowyPunkt q = new KolorowyPunkt(10, 20, 10);
				q.Wypisz();

				KolorowyPunkt r = new KolorowyPunkt(q);
				r.Wypisz();

				Console.ReadKey();
			}
		}
	}
}
