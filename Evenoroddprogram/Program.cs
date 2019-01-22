// Exercise 2
// Input a number (n) from the user and check if it is even or odd.


using System;

namespace Evenoroddprogram
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter an ineteger to check whether it is even or odd");
			long number = long.Parse(Console.ReadLine()); // taking long data type to support greater range of inetegers
			try
			{
				if (number % 2 == 0)
					Console.WriteLine("Number entered is {0} and {0} is a even number", number);
				else
					Console.WriteLine("Number entered is {0} and {0} is a odd number", number);
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			Console.ReadKey(true);
		}
	}
}
