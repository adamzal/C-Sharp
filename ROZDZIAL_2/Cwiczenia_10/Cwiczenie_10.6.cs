using System;

public class Program
{
	public static void Main()
	{
		int i=100;
		for(;i>0;i--)
		{
			if(i%3==0&&i%2!=0)
				Console.Write(i+"\t");
		}
		Console.WriteLine("");
		i=100;
		while(i>0)
		{
                        if(i%3==0&&i%2!=0)
                                Console.Write(i+"\t");
			i--;
		}	
                Console.WriteLine("");
                i=100;
		do
		{
                        if(i%3==0&&i%2!=0)
                                Console.Write(i+"\t");
		}
		while(i-->1);
		Console.ReadKey();
	}
}
