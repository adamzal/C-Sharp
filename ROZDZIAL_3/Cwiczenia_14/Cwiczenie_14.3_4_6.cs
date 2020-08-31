using System;

public class Punkt
{
    int x;
    int y;


    class Prostokat
    {
        Punkt A = new Punkt();
        Punkt B = new Punkt();
        Punkt C = new Punkt();
        Punkt D = new Punkt();

        void WyswietlWspolrzedne()
        {
            Console.WriteLine("Współrzędne punktu A=({0};{1})", A.x, A.y);
            Console.WriteLine("Współrzędne punktu B=({0};{1})", B.x, B.y);
            Console.WriteLine("Współrzędne punktu C=({0};{1})", C.x, C.y);
            Console.WriteLine("Współrzędne punktu D=({0};{1})", D.x, D.y);
        }

        int ZwrocAx()
        {
            return A.x;
        }

        int ZwrocAy()
        {
            return A.y;
        }

        int ZwrocBx()
        {
            return B.x;
        }


        int ZwrocBy()
        {
            return B.y;
        }

        int ZwrocCx()
        {
            return C.x;
        }

        int ZwrocCy()
        {
            return C.y;
        }

        int ZwrocDx()
        {
            return D.x;
        }

        int ZwrocDy()
        {

            return D.y;
        }

	bool CzyProstokat()
	{
		return A.x==D.x&&A.y==B.y&&B.x==C.x&&C.y==D.y?true:false;
	}

        public static void Main()
        {
            Prostokat ABCD = new Prostokat();
            ABCD.A.x = -2;
            ABCD.A.y = 2;
            ABCD.B.x = 3;
            ABCD.B.y = 2;
            ABCD.C.x = 3;
            ABCD.C.y = 10;
            ABCD.D.x = -2;
            ABCD.D.y = 10;
            ABCD.WyswietlWspolrzedne();
            Console.WriteLine("{0};{1}", ABCD.ZwrocAx(), ABCD.ZwrocAy());
            Console.WriteLine("{0};{1}", ABCD.ZwrocBx(), ABCD.ZwrocBy());
            Console.WriteLine("{0};{1}", ABCD.ZwrocCx(), ABCD.ZwrocCy());
            Console.WriteLine("{0};{1}", ABCD.ZwrocDx(), ABCD.ZwrocDy());
	    Console.WriteLine(ABCD.CzyProstokat());
	    Console.ReadKey();
        }
    }
}    
