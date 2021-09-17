using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStarted.OneZeroOne
{
	/// <summary>
	/// Operators are used to perform operations on variables and values.
	/// </summary>
	public static class Operators
	{
		public static void CommonOperatos() //it is nested method call i.e. calling one method inside other
		{
			Addition(); 
			Subtraction();
			Multiplication();
			Division();
			Modulus();
			Increment();
			Decrement();
		}

		private static void Addition() //If you don't understand 'private', it is coming later
		{
			int x = 7;
			int y = 1;
			Console.WriteLine("Addition Operator: {0}", x + y);
		}

		private static void Subtraction()
		{
			int x = 15;
			int y = 13;
			Console.WriteLine("Subtraction Operator: {0}", x - y);
		}

		private static void Multiplication()
		{
			int x = 8;
			int y = 9;
			Console.WriteLine("Multiplication Operator: {0}", x * y);
		}

		private static void Division()
		{
			int x = 18;
			int y = 2;
			Console.WriteLine("Division Operator: {0}", x / y);
		}

		private static void Modulus() //Returns the division remainder
		{
			int x = 67;
			int y = 9;
			Console.WriteLine("Modulus Operator: {0}", x % y);
		}

		private static void Increment() //Increases the value of a variable by 1
		{
			int x = 8;
			x++;
			Console.WriteLine("Increment Operator: {0}", x);
		}

		private static void Decrement() //Decreases the value of a variable by 1
		{
			int x = 8;
			x--;
			Console.WriteLine("Decrement Operator: {0}", x);
		}
	}
}
