using System;
using System.Text;

namespace learncsharp.practice
{
	public class strings
	{
		public static void Main(string[] args)
		{
			string s = "HelloWorld";
			Console.WriteLine(s.Length);
			Console.WriteLine("substring: " + s.Substring(0, 5)); //Hello
			Console.WriteLine("Upper: " + s.ToUpper());
            Console.WriteLine("Lower: " + s.ToLower());
			string str = s.Replace("World", "Prachee");
			Console.WriteLine("Replaced string: " + str);
			//IsNullorEmpty for checking if string is null or empty or IsNullorWhitespace for whitespaces in string
			StringBuilder sb = new StringBuilder("HelloWorld");
			int l = sb.Length;
			Console.WriteLine("Length: " + l);
			sb.Insert(10, "Prachee");
			Console.WriteLine(sb.ToString());
			
        }
	}
}

