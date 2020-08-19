using System;

public class Program
{
	public static void Main()
	{
		int dl=5;
		int r=6;
		if(2*r>=5*Math.Sqrt(2))
		{
			Console.WriteLine("Podany kwadrat o boku {0} mieści się w okręgu o promieniu {1}.",dl,r);
		}
		else
		{
			Console.WriteLine("Podany kwadrat jest za duży i nie mięsci się w okręgu.");
		}
		Console.ReadKey();
	}
}
