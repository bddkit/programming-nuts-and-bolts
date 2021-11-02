using System;

namespace GettingStarted.OneZeroOne
{
	/// <summary>
	/// bool data type takes the value either true or false
	/// </summary>
	public static class Booleans
	{
		/// <summary>
		/// A boolean type is declared with the bool keyword and can take the value either true or false
		/// </summary>
		public static void Values()
		{
			bool isProgrammingFun = true;
			bool isBurgerHealthy = false;
			Console.WriteLine(isProgrammingFun + "\n");   // Outputs True
			Console.WriteLine(isBurgerHealthy + "\n");   // Outputs False
		}

		/// <summary>
		/// A Boolean expression is a C# expression that returns a Boolean value: True or False.
		/// We can use a comparison operator, such as the greater than (>) operator to find out if an expression is true
		/// </summary>
		public static void Expression()
		{
			Console.WriteLine(5 > 4); // returns True, because 5 is higher than 4
			Console.Write("\n");
			Console.WriteLine(5 == 5); // returns True, because the value 5 is equal to 5
			Console.Write("\n");
			Console.WriteLine(5 == 4); // returns False, because 5 is not equal to 4
			Console.Write("\n");
		}
	}
}
