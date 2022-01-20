using System;

namespace GettingStarted.OneZeroOne
{
	public class Conditions
	{
		/// <summary>
		/// C# supports logical conditions from mathematics:
		/// Less than: a<b
		//  Less than or equal to: a <= b
		/// Greater than: a> b
		/// Greater than or equal to: a >= b
		/// Equal to a == b
		/// Not Equal to: a != b
		/// </summary>
		public static void Learn()
		{
			/*
			  C# has the following conditional statements:
				a. Use if to specify a block of code to be executed, if a specified condition is true
				b. Use else to specify a block of code to be executed, if the same condition is false
				c. Use else if to specify a new condition to test, if the first condition is false
				d. Use switch to specify many alternative blocks of code to be executed
			*/

			//if condition
			int x = 15;
			if (x > 10) // greater than condition
			{
				Console.WriteLine("15 is greater than 10"); // this line will be printed because 10 is greater than 15
			}


			int y = 10;
			//if-else condition
			if (y > 15)
			{
				Console.WriteLine("10 is greater than 15");
			}
			else
			{
				Console.WriteLine("10 is not greater than 15");
			}

			int time = 15;
			//else-if condition
			if (time < 10)
			{
				Console.WriteLine("if condition");
			}
			else if (time < 20)
			{
				Console.WriteLine("else if condition");
			}
			else
			{
				Console.WriteLine("else condition");
			}

			//Ternary operator i.e., short hand if else condition
			string result = 5 > 2 ? "5 is greater than 2" : "5 is not greater than 2";
			Console.WriteLine(result);

			//switch is used to select one of many code blocks to be executed
			/*
			 switch(expression) 
				{
				  case x:
					// code block
					break;
				  case y:
					// code block
					break;
				  default:
					// code block
					break;
				}
			 */
			int number = 4;
			//switch is evaluated only once, the value of the expression is compared with the values of each case.
			//If there is a match, the associated block of code is executed.
			//break stops the execution of more code and case testing
			switch (number) 
			{
				case 1:
					Console.WriteLine("1"); //code block
					break; 
				case 2:
					Console.WriteLine("2");
					break;
				case 3:
					Console.WriteLine("3");
					break;
				case 4:
					Console.WriteLine("4");
					break;
				case 5:
					Console.WriteLine("5");
					break;
				case 6:
					Console.WriteLine("6");
					break;
				case 7:
					Console.WriteLine("7");
					break;
				default: // if no case matches this block will be executed since it is default
					Console.WriteLine("default"); 
					break;
			}
		}
	}
}
