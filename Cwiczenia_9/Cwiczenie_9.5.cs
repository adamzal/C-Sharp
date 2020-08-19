using System;

public class Program
{
	public static void Main()
	{
		int a=5
		switch(a==1||a==4||a==8)
		{
			case true:
				Console.WriteLine("Liczba ma wartość 1, 4 lub 8");
				break;
			case false:
				switch(a==2||a==3||a==7)
				{
					case true:
						Console.WriteLine("Liczba ma wartość 2,3 lub 7");
						break;
					case false:
						Console.WriteLine("Liczba ma inną wartość");
						break;
				}
				break;
		}
		Console.ReadKey();
	}
}

