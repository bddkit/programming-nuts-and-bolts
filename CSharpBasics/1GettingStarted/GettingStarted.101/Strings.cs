using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStarted.OneZeroOne
{
	/// <summary>
	/// Strings are used for storing text.	
	/// </summary>
	public static class Strings
	{
		public static void SimpleString()
		{
			//A string variable contains a collection of characters surrounded by double quotes
			string str = "Simple string";
			Console.WriteLine(str + "\n");
		}

		public static void StringMethods()
		{
			//Find the length of the string
			string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			Console.WriteLine("The length of the text is: " + txt.Length + "\n");

			//Convert lower case letter to upper case and vice versa
			string upercase = "upper case letters";
			string lowercase = "LOWER CASE LETTERS";
			Console.WriteLine(upercase.ToUpper() + "\n");   
			Console.WriteLine(lowercase.ToLower() + "\n");

			//The + operator can be used to join strings which is called concatenation.
			string firstName = "Mohammed ";
			string lastName = "Abdullah";
			string name = firstName + lastName;
			Console.WriteLine("Concatenated name: " + name + "\n");
		}
	}
}
