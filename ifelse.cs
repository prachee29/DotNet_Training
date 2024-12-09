using System;
namespace learncsharp.practice
{
	public class ifelse
	{
		public ifelse()
		{
		}
		public static void Main(string[] args)
		{
			int x = Convert.ToInt32(Console.ReadLine());
			switch(x)
			{
                case 1:
                    Console.WriteLine("1");
                    break;

                default:
                    Console.WriteLine("Not valid input");
                    break;
            }
				
		}
	}
}

