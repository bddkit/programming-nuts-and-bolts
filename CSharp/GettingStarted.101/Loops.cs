using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStarted.OneZeroOne
{
	/// <summary>
	/// Looping in a programming language is a technique to execute a statement(s
	/// multiple times until the specified condition is reached. 
	/// </summary>
	public static class Loops
	{
		/// <summary>
		/// The loops in which condition to be tested is at the beginning of loop body.
		/// E.g., while loop and for loop
		/// </summary>
		public static void EntryControlledLoops()
		{
			WhileLoop();
			ForLoop();
		}

		/// <summary>
		/// The loops in which condition to be tested is at the end of loop body.
		/// E.g., do-while loop
		/// </summary>
		public static void ExitControlledLoops()
		{
			DoWhileLoop();
		}

		/// <summary>
		/// The loops in which the test condition does not ever met, thus an external force is used to end it.
		/// Therefore these loops are known as infinite loops.
		/// </summary>
		public static void InfiniteLoop()
		{
			// The statement will be executed
			// infinite times
			for (; ; )
				Console.WriteLine("Infinite for loop!");
		}

		/// <summary>
		/// The break statement can be used to jump out of a loop.
		/// This example jumps out of the loop when x is equal to 5:
		/// </summary>
		public static void LoopWithBreak()
		{
			for (int x = 0; x < 10; x++)
			{
				if (x == 5)
				{
					break;
				}
				Console.WriteLine(x);
			}
		}

		/// <summary>
		/// The continue statement breaks one iteration (in the loop), if a specified condition occurs,
		/// and continues with the next iteration in the loop.
		/// This example skips the value of 5:
		/// </summary>
		public static void LoopWithContinue()
		{
			for (int x = 0; x < 10; x++)
			{
				if (x == 5)
				{
					continue;
				}
				Console.WriteLine(x);
			}
		}

		/// <summary>
		/// When loops are executed inside another loops, it is known as nested loops.
		/// </summary>
		public static void NestedLoops()
		{
			for (int x = 2; x < 3; x++)
				for (int y = 1; y < x; y++)
					Console.WriteLine("Inside nested loop");
		}

		/// <summary>
		/// When the condition is false the control will be out from the while loop
		/// </summary>
		private static void WhileLoop()
		{
			int i = 1;

			// Exit when i is greater than 5
			while (i <= 5)
			{
				Console.WriteLine("Value of i: " + i);

				// Increment the value of i for
				// the next iteration
				i++;
			}
		}

		private static void ForLoop()
		{
			/*
				for (statement 1; statement 2; statement 3) 
				{
					 code block to be executed
				}
				Statement 1 (Initialization of loop variable) is executed(only once) before the execution of the code block.
				Statement 2 (Testing Condition) defines the condition for executing the code block.
				Statement 3 (Increment / Decrement) is executed(every time) after the code block has been executed.
			*/

			// for loop begins when i=1
			// and runs until i <=5
			for (int i = 1; i <= 4; i++)
				Console.WriteLine("Value of i: " + i);
		}

		/// <summary>
		/// The do-while loop is a variant of the while loop. This loop will execute the code block once,
		/// before checking if the condition is true, then it will repeat the loop as long as the condition is met.
		/// </summary>
		private static void DoWhileLoop()
		{
			int x = 0;
			do
			{
				Console.WriteLine("Value of x: " + x);
				x++;
			}
			while (x < 5);
		}
	}
}
