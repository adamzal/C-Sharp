using System;

class Punkt
{
	double x;
	double y;

	class Kwadrat
	{
		int bok;
		Punkt D=new Punkt();
		Punkt B=new Punkt();

		int abs(int a)
		{
			return a>=0?a:-a;
		}

		Kwadrat(Punkt D,Punkt B)
		{
			this.D=D;
			this.B=B;
		}

		Kwadrat(Punkt D,int bok)
		{
			this.bok=bok;
			this.D=D;
			B.x=D.x+bok;
			B.y=D.y-bok;
		}

		Kwadrat(int x,int y,int bok)
		{
			this.bok=bok
			D.x=x+bok/2=D.y;
			B.x=x-bok/2=B.y;
		}

		Kwadrat(int x,int y,double pole)
		{
			this.bok=Math.Sqrt(pole);
			D.y=D.x=x+bok/2;
			B.y=B.x=x-bok/2;
		}

		void WyswietlWspolrzedne()
		{
			Console.WriteLine("B({0};{1})",B.x,B.y);
                        Console.WriteLine("B({0};{1})",D.x,D.y);
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
        		Kwadrat EFGH = new Kwadrat(0,0, 6);
        		EFGH.WyswietlWspolrzedne();
        		Kwadrat efgh = new Kwadrat(0,0, 64.0);
        		efgh.WyswietlWspolrzedne();
		        Console.ReadKey();
		}
	}
}
