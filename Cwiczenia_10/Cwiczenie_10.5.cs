using System;

public class Program
{
	public static void Main()
	{
		int i=1;
		for(;i<21;i++)
		{
			if(i%2==0)
				Console.Write(i+"p\t");
			else
				Console.Write(i+"np\t");
		}
		Console.WriteLine("");
		i=1;
		while(i<21)
		{
                        if(i%2==0)
                                Console.Write(i+"p\t");
                        else
                                Console.Write(i+"np\t");
			i++;
		}
                Console.WriteLine("");
                i=1;
		do
		{
                        if(i%2==0)
                                Console.Write(i+"p\t");
                        else
                                Console.Write(i+"np\t");
		}
		while(i++<20);
		Console.ReadKey();
	}
}



