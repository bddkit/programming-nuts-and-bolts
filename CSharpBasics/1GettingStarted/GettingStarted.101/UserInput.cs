using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStarted.OneZeroOne
{
	//We know how to output/print values, now we are going to learn how to get input from user
	public static class UserInput
	{
		public static void ReadInput()
		{
			// Type your username and press enter
			Console.WriteLine("Enter username:");

			// Create a string variable and get user input from the keyboard and store it in the variable
			string userName = Console.ReadLine();

			// Print the value of the variable (userName), which will display the input value
			Console.WriteLine("Username is: " + userName);

			//For integer we need to type cast
			Console.WriteLine("Enter your age:");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Your age is: " + age);
		}
	}
}
