using System;
namespace learncsharp.practice
{
	public class c1
	{
		public string name;
		public string surname;
		public c1(string n,string s)
		{
			name = n;
			surname = s;
		}

		public static void Main(string[] args)
		{
			c1 students = new c1("Prachee","Shukla");
			Console.WriteLine("Name: " + students.name + " ,Surname: " + students.surname);
		}
	}
}

