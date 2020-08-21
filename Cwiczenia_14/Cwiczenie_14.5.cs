using System;

public class Punkt
{
	int x;
	int y;

	public class Prostokat
	{
		Punkt A = new Punkt();
		Punkt C = new Punkt();

		void WspolrzedneB()
		{
			Console.WriteLine("Współrzędne B=({0};{1})",C.x,A.y);
		}

                void WspolrzedneD()
                {
                        Console.WriteLine("Współrzędne D=({0};{1})",A.x,C.y);
                }

		public static void Main()
		{
			Prostokat ABCD = new Prostokat();
			ABCD.A.x=-2;
			ABCD.A.y=2;
			ABCD.C.x=3;
			ABCD.C.y=10;
			ABCD.WspolrzedneB();
			ABCD.WspolrzedneD();
			Console.ReadKey();
		}
	}
}
