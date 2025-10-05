
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;
using System.Linq;


namespace Main
{
	internal class Program
	{

		static void myMethod(string child1, string child2, string child3)
		{
			Console.WriteLine("The youngest child is: " + child3);
		}
		static void Main(string[] args)
		{

			Random rnd = new Random();

			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine(rnd.Next(1,10));
			}


		}
	}
}
