using System;

public class Program
{
	public static void Main()
	{
		char[] tab=new char[26];
		int i=0;
		for(;i<26;i++)
		{
			tab[i]=(char)('a'+i);
		}
		for(i=0;i<26;i++)
		{
			Console.WriteLine("tab[{0}]={1}",i,tab[i]);
		}
		Console.ReadKey();
	}
}
