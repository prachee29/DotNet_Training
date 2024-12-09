using System;
namespace learncsharp.practice
{
	public class methods2
	{
		public virtual void show()
		{
			Console.WriteLine("Base class");
		}
	}
	public class me:methods2
	{
		public override void show()
		{
			Console.WriteLine("Derived class");
		}

	}
	public class meth
	{
		public static void Main(string[] args)
		{
			methods2 obj = new methods2();
			obj.show();
			obj = new me();
			obj.show();

		}

	}
}

