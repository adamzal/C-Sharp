using System;

class Punkt
{
	int x;
	int y;

	class Prostokat
	{
		Punkt D=new Punkt();
		Punkt B= new Punkt();

		int abs(int a)
		{
			return a>=0?a:-a;
		}

		Prostokat(int x,int y,int szer,int wys)
		{
			this.D.x=x;
			this.D.y=y;
			B.x=szer-abs(D.x);
			B.y=abs(D.y)-wys;
		}

		void WyswietlWspolrzedne()
		{
			Console.WriteLine("B=({0};{1})",B.x,B.y);
			Console.WriteLine("D=({0};{1})",D.x,D.y);
		}

		public static void Main()
		{
			Prostokat ABCD=new Prostokat(-2,10,5,8);
			ABCD.WyswietlWspolrzedne();
			Console.ReadKey();
		}
	}
}

