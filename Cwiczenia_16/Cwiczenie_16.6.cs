using System;

class Punkt
{
	int x;
	int y;

	class Kwadrat
	{
		Punkt D=new Punkt();
		Punkt B=new Punkt();

		Kwadrat(Punkt D,Punkt B)
		{
			this.D=D;
			this.B=B;
		}

		Kwadrat(Punkt D,int bok)
		{
			this.D=D;
			B.x=D.x+bok;
			B.y=D.y-bok;
		}

		Kwadrat(int x,int y,int bok)
		{
			D.x=x+bok/2=D.y;
			B.x=x-bok/2=B.y;
		}

		Kwadrat(int x,int y,double pole)
		{
			int bok=Math.sqrt(pole);
			Kwadrat(x,y,bok)
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
