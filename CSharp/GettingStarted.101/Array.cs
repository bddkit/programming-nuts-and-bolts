using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStarted.OneZeroOne
{
	/// <summary>
	/// instead of declaring separate variables for each value
	/// Arrays are used to store multiple values in a single variable. 
	/// Together with variable type square brackets are used to declare an array.
	/// </summary>
	public static class Array
	{
		/// <summary>
		/// Shows how to create, access, modify etc. an array.
		/// </summary>
		public static void Learn()
		{
			//Create and access an array
			string[] friends = { "Abdullah", "Umair", "Osman", "Omar" };
			Console.WriteLine(friends[0]); //array's index starts from zero(0) and output is "Abdullah"

			//modify an element in an array
			friends[0] = "Abdur Rahman";
			Console.WriteLine(friends[0]); //output is now "Abdur Rahman"

			//find how many elements in an array
			Console.WriteLine(friends.Length); //output is 4

			//The foreach loop is used exclusively to loop through elements in an array
			foreach (string friend in friends)
			{
				Console.WriteLine(friend);
			}
		}
	}
}
