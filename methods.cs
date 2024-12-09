using System;
namespace learncsharp.practice
{
	public class methods
	{
		public static void fact(int x)
		{
			int f = 1;
			for(int i=1;i<=x;i++)
			{
				f = f * i;
			}
			Console.WriteLine(f);

		}
		public static void Main(string[] args)
		{
			int p = 4;
			fact(p);

		}
	}
}

