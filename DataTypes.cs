using System;
namespace learncsharp.practice
{
	enum tasks_num
	{
		work=2,
		sleep=1,
		eat=3
	}
	public class DataTypes
	{
		public DataTypes()
		{
		}
		public static void Main(string[] args)
		{

			//value type
			int a = 10;
			float b = 2.2F;
			double c = 3.3;
			decimal d = 4.4M;
			Console.WriteLine(a + "," + b + "," + c + "," + d);

			//reference type
			string s = "Hello";
			s += "World";
			Console.WriteLine(s);

			//pointer type
			unsafe
			{
				int n = 10;
				int* p = &n;
				Console.WriteLine(n);
				Console.WriteLine(*p);
			}

			tasks_num x = tasks_num.sleep;
			Console.WriteLine(x);




		}

	}
}

