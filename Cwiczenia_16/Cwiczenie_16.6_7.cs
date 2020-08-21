using System;

class Punkt
{
	double x;
	double y;

	class Kwadrat
	{
		double bok;
		Punkt D = new Punkt();
		Punkt B = new Punkt();

		double abs(double a)
		{
			return a >= 0 ? a : -a;
		}

		Kwadrat(Punkt D, Punkt B)
		{
			this.D = D;
			this.B = B;
			if (D.x >= 0 && B.x >= 0)
			{
				this.bok = B.x - D.x;
			}
			if (D.x < 0 && B.x >= 0)
			{
				this.bok = abs(D.x) + B.x;
			}
			if (D.x < 0 && B.x < 0)
			{
				this.bok = abs(D.x) - abs(B.x);
			}
		}

		Kwadrat(Punkt D, double bok)
		{
			this.bok = bok;
			this.D = D;
			B.x = D.x + bok;
			B.y = D.y - bok;
		}

		Kwadrat(double x, double y, double bok)
		{
			this.bok = bok;
			D.x = D.y = x + bok / 2;
			B.x = B.y = x - bok / 2;
		}

		Kwadrat(double x, double y, double pole, bool czypole)
		{
			if (czypole)
			{
				this.bok = Math.Sqrt(pole);
				D.y = D.x = x + bok / 2;
				B.y = B.x = x - bok / 2;
			}
			else
			{
				this.bok = bok;
				D.x = D.y = x + bok / 2;
				B.x = B.y = x - bok / 2;
			}
		}

		void WyswietlWspolrzedne()
		{
			Console.WriteLine("B({0};{1})", B.x, B.y);
			Console.WriteLine("D({0};{1}) bok={2}", D.x, D.y, bok);
		}

		public static void Main()
		{
			Punkt B = new Punkt();
			B.x = 0;
			B.y = 1;
			Punkt D = new Punkt();
			D.x = -4;
			D.y = 5;
			Kwadrat ABCD = new Kwadrat(D, B);
			ABCD.WyswietlWspolrzedne();
			Kwadrat abcd = new Kwadrat(D, 5);
			abcd.WyswietlWspolrzedne();
			Kwadrat EFGH = new Kwadrat(0, 0, 6);
			EFGH.WyswietlWspolrzedne();
			Kwadrat efgh = new Kwadrat(0, 0, 64.0, true);
			efgh.WyswietlWspolrzedne();
			Console.ReadKey();
		}
	}
}