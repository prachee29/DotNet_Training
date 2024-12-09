using System;
namespace learncsharp.practice
{

	public class car
	{
		public string name;
		public string quality;
		public void about()
		{
			Console.WriteLine("This is a good car");
		}

	}

	public class p1
	{
		string color = "Red";
		public static void Main(string[] args)
		{
			car c1 = new car();
			c1.name = "Audi";
			c1.quality = "good";
			Console.WriteLine(c1.name + " " + c1.quality);
			c1.about();
			//p1 obj = new p1();
			//Console.WriteLine(obj.color);
		}
	}
}

