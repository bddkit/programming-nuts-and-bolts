using System;

namespace GettingStarted.OneZeroOne
{
	/// <summary>
	/// Type casting is when you assign a value of one data type to another type.
	/// </summary>
	public static class TypeCasting
	{
		//Two types of type casting Implicit and Explicit
		public static void ImplicitTypeCasting()
		{
			//Implicit Casting (automatically) - converting a smaller type to a larger type size
			//char -> int -> long -> float -> double
			int intNumber = 5;
			double doubleNumber = intNumber;       // Automatic casting: int to double

			Console.WriteLine(intNumber);      // Outputs 5
			Console.WriteLine(doubleNumber);   // Outputs 5
		}

		public static void ExplicitTypeCasting()
		{
			//Explicit Casting (manually) - converting a larger type to a smaller size type
			//double -> float -> long -> int -> char
			double doubleNumber = 5.789;

			//Explicit casting must be done manually by placing the type in parentheses in front of the value			
			int intNumber = (int)doubleNumber;     

			Console.WriteLine(doubleNumber);      // Outputs 5.789
			Console.WriteLine(intNumber);         // Outputs 5
		}


		public static void BuiltInTypeConversionMethods()
		{
			//It is possible to convert data types explicitly by using built-in methods,
			//such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)
			int intNumber = 10;
			double doubleNumber = 5.25;
			bool boolNumber = true;

			Console.WriteLine(Convert.ToString(intNumber));    // convert int to string
			Console.WriteLine(Convert.ToDouble(intNumber));    // convert int to double
			Console.WriteLine(Convert.ToInt32(doubleNumber));  // convert double to int
			Console.WriteLine(Convert.ToString(boolNumber));   // convert bool to string
		}
	}
}
