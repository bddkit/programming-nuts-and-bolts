using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStarted.OneZeroOne
{
	//variables are holders for data values 
	public static class Variables
	{
		public static void PrintAllTypesOfVariables()
		{
			//There are different kinds of variables in C#
			int id = 0; //int stores integers i.e., whole numbers without decimal such as 123 or -123
			Console.WriteLine("Int: {0}", id);
			double price = 0.0; // stores floating point mumbers with decimal e.g., 85.12 or -78.96
			Console.WriteLine("Double: {0}", price);
			char c = 'A'; // stores single char like 'a', 'B'
			Console.WriteLine("Char: {0}", c);
			string text = "HELLO WORLD"; // string stores text 
			Console.WriteLine("String: {0}", text);
			bool TrueFalse = false; //stores value either true or false
			Console.WriteLine("Bool: {0}", TrueFalse);
		}
	}
}
