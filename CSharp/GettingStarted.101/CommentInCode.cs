using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStarted.OneZeroOne
{
	public static class CommentInCode
	{
		public static void PrintTypesOfCommentsInCode()
		{
			//Comments can be used to explain C# code, and to make it more readable.

			//This is single line comment"

			/* 
			 * This is multiline comments
			 * Next line
			 * Next line
			 */

			//Printing single line comment
			Console.WriteLine("@//This is single line comment\n");
			
			//printing multi line comment
			Console.WriteLine(@"/* 
			 * This is multiline comments
			 * Next line
			 * Next line
			 */");
		}
	}
}
