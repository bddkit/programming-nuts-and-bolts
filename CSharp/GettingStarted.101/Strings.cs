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
			string concatName = firstName + lastName;
			Console.WriteLine("Concatenated name: " + concatName + "\n");

			//string.Concat() method to concatenate two strings
			string fullname = string.Concat(firstName, lastName);
			Console.WriteLine("string.Concat(): " + fullname + "\n");

			//string interpolation, that substitutes values of variables into placeholders in a string
			//have to use the dollar sign ($) when using the string interpolation method (introduced in C# version 6)
			string interpolationName = $"My full name is using (interpolation): {firstName} {lastName}";
			Console.WriteLine(interpolationName + "\n");

			//access the character in a string by index number inside square brackets []
			//[0] is the first character.
			string uString = "Index";
			Console.WriteLine("Character using index: " + uString[0] + "\n");  // Outputs "I"

			//find the index position of a specific character in a string by using the IndexOf() 
			Console.WriteLine("Character using IndexOf(): " + uString.IndexOf("e") + "\n");  // Outputs "3"

			//Substring() extracts the characters from a string
			//starting from the specified character position/index, and returns a new string
			// Location of the letter d
			int charPos = uString.IndexOf("d");

			//get last name
			string subString = uString.Substring(charPos);

			//print the result
			Console.WriteLine("String using Substring(): " + subString + "\n");
		}

		/// <summary>
		/// strings must be written within quotes, C# will misunderstand the string that contains special
		/// characters like single quote, double quote or backslash
		/// This will generate error: string txt = "Say "we are brave!"";;
		/// </summary>
		public static void SpecialCharacters()
		{
			//To solve this problem backslash can be used
			//The backslash (\) escape character turns special characters into string characters
			//'\n' new line
			//'\t' Tab
			//'\b' Back space
			string txt = "It\'s a valid string";
			Console.WriteLine("Convert special char into string using backslash: " + txt + "\n");

			//Adding Numbers and Strings
			//C# uses the + operator for both addition and concatenation.
			//Numbers are added.Strings are concatenated.
			int a = 45;
			int b = 65;
			int c = a + b;  // c will be 110 (an integer/number)
			Console.WriteLine("Numbers are added by concatenaing: " + c + "\n");

			string s = "45";
			string t = "65";
			string u = s + t;  // u will be 4565 (a string)
			Console.WriteLine("Strings are added by concatenaing: " + u + "\n");
		}
	}
}
