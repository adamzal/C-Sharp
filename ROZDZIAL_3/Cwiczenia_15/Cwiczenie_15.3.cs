using System;

class Punkt
{
        int x;
        int y;

	int PobierzX()
        {
                return x;
        }

        int PobierzY()
        {
                return y;
        }

        int UstawX(int wspX)
        {
                int pom = x;
                x = wspX;
                return pom;
        }

        void UstawX(Punkt p)
        {
                x = p.x;
        }

	void UstawY(int wspY)
	{
		int pom = y;
		y=wspY;
		return pom;
	}

        void UstawY(Punkt p)
        {
                y = p.y;
        }

	void UstawXY(int wspX, int wspY)
        {
                x = wspX;
                y = wspY;
        }

	Punkt UstawXY(Punkt p)
	{
		Punkt q=new Punkt();
		q.x=x;
		q.y=y;
		x=p.x;
		y=p.y;
		return q;
	}

        void WyswietlWspolrzedne()
        {
                Console.WriteLine("współrzędna x = " + x);
                Console.WriteLine("współrzędna y = " + y);
        }

        public static void Main()
        {

		Punkt drugiPunkt = new Punkt();
                pierwszyPunkt.UstawXY(100,100);

                Console.WriteLine("pierwszyPunkt:");
                pierwszyPunkt.WyswietlWspolrzedne();

                Console.WriteLine(pierwszyPunkt.UstawX(150));
                Console.WriteLine(pierwszyPunkt.UstawY(200));

                Console.WriteLine("pierwszyPunkt:");
                pierwszyPunkt.WyswietlWspolrzedne();

                drugiPunkt.UstawX(pierwszyPunkt);
                drugiPunkt.UstawY(pierwszyPunkt);

                Console.WriteLine("\ndrugiPunkt:");
                drugiPunkt.WyswietlWspolrzedne();
                Console.ReadKey();
        }
}
