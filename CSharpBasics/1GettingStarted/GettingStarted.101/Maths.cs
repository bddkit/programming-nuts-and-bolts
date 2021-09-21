using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStarted.OneZeroOne
{
	public static class Maths
	{
		public static void MathmaticalTasks()
		{
			//the Math.Max(x, y) method can be used to find the highest value of x and y
			int x = 49;
			int y = 89;
			Console.WriteLine("Max task - Value of \" Math.Max({0}, {1})\" is {2}\n", x, y, Math.Max(x, y));

			//The Math.Min(x,y) method can be used to find the lowest value of of x and y
			Console.WriteLine("Min task - Value of \" Math.Min({0}, {1})\" is {2}\n", x, y, Math.Min(x, y));

			//The Math.Sqrt(x) method returns the square root of x
			Console.WriteLine("Sqrt task - Value of \" Math.Sqrt({0})\" is {1}\n", x, Math.Sqrt(x));

			//The Math.Abs(x) method returns the absolute (positive) value of z
			double z = -5.8;
			Console.WriteLine("Abs task - Value of \"Math.Abs({0})\" is {1}\n", z, Math.Abs(z));

			//Math.Round() rounds a number to the nearest whole number
			double i = 9.99;
			Console.WriteLine("Round task - Value of \"Math.Abs({0})\" is {1}\n", i, Math.Round(i));
		}
	}
}
