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

		Kwadrat(Punkt D, Punkt B)
		{
			this.D = D;
			this.B = B;
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
			Console.WriteLine("B({0};{1})", D.x, D.y);
		}

		public static void Main()
		{
			Punkt B = new Punkt();
			B.x = -4;
			B.y = 5;
			Punkt D = new Punkt();
			D.x = 0;
			D.y = 1;
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