using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStarted.OneZeroOne
{
	/// <summary>
	/// Operators are used to perform operations on variables and values.
	/// </summary>
	public static class Operators
	{
		public static void CommonOperatos() //it is nested method call i.e. calling one method inside other
		{
			Addition();
			Subtraction();
			Multiplication();
			Division();
			Modulus();
			Increment();
			Decrement();
		}

		public static void AssignmentOperators()
		{
			//assignment
			int a = 10;
			Console.WriteLine("Assignment - Value of \"a = 10\" is {0}\n", a);

			//addition assignment operator (+=)
			int b = 10;
			Console.WriteLine("Subtraction assignment - Value of \"10 += 5\" is {0}\n", b += 5); // equivalent to b = b + 5;

			//subtraction assignment operator (-=)
			int c = 5;
			Console.WriteLine("Subtraction assignment - Value of \"5 -= 3\" is {0}\n", c -= 3); // equivalent to c = c - 3;

			// multiplication assignment operator (*=)
			int d = 5;
			Console.WriteLine("Multiplication assignment - Value of \"5 *= 3\" is {0}\n", d *= 3); // equivalent to d = d * 3;

			//division assignment operator (/=)
			double e = 5;
			Console.WriteLine("Division assignment - Value of \"5 /= 3\" is {0}\n", e /= 3); // equivalent to e = e / 3;

			//modulas assignment operator (%=)
			int f = 5;
			Console.WriteLine("Modulas assignment - Value of \"5 %= 3\" is {0}\n", f %= 3); // equivalent to f = f % 3;


			int g = 20; /* 20 = 010100 */
			int h = 21; /* 21 = 010101 */
			int i = 0;

			//bitwise AND assignment (&=)
			//operation is 1 if both the bits have the value as 1
			i = g & h;       /* 20 = 010100 */
			Console.WriteLine("bitwise AND - Value of \"{0} & {1}\" is {2}\n", g, h, i); //equivalent to  g &= h

			//bitewise OR assignment (|=)
			// 1 if at least one of the expression has the value as 1
			i = g | h;       /* 21 = 010101 */
			Console.WriteLine("Bitwise OR - Value of \"{0} | {1}\" is {2}\n", g, h, i); //equivalent to  g |= h

			//bitwise exclusive XOR (^)
			//The result is zero only when we have two zeroes or two ones
			i = g ^ h;       /* 1 = 0001 */
			Console.WriteLine("Bitwise exlusive XOR - Value of \"{0} ^ {1}\" is {2}\n", g, h, i); //equivalent to  g ^ h

			//The bitwise shift operators are used to move/shift the bit patterns either to the left or right side. 
			//Operand << n(Left Shift)
			//Operand >> n(Right Shift)
			/*
				an operand is an integer expression on which we have to perform the shift operation.
				‘n’ is the total number of bit positions that we have to shift in the integer expression.
			 */
			int j = 20; /* 20 = 0001 0100 */

			//The left shift operation will shift the ‘n’ number of bits to the left side.
			//The leftmost bits in the expression will be popped out, and n bits with the value 0 will be filled on the right side.
			int k = j << 2; /* 80 = 0101 0000 */
			Console.WriteLine("Left shift - Value of \"{0} << 2\" is {1}\n", j, k); //equivalent to  j <<= 2

			//The right shift operation will shift the ‘n’ number of bits to the right side.
			//The rightmost ‘n’ bits in the expression will be popped out, and the value 0 will be filled on the left side.
			k = j >> 2; /*05 = 0000 0101 */
			Console.WriteLine("Right shift - Value of \"{0} >> 2\" is {1}\n", j, k); //equivalent to  j >>= 2
		}

		public static void LogicalOperators()
		{
			int x = 6;
			
			//'Logical and' returns true if both statements are true
			Console.WriteLine("Result of \"Logical and\" Operator - Value of \"{0} > 5 && {1} < 9\" is {2}\n", x, x, x > 5 && x < 9); // returns True because 6 is greater than 5 AND 6 is less than 9

			//'Logical or' returns true if one of the statements is true
			Console.WriteLine("Result of \"Logical or\" Operator - Value of \"{0} > 5 || {1} < 3\" is {2}\n", x, x, x > 5 || x < 3); // returns True because one of the conditions are True (6 is greater than 5, but 6 is not less than 3)

			//'Logical not' reverse the result, returns false if the result is true
			Console.WriteLine("Result of \"Logical not\" Operator - Value of \"!({0} > 5 && {1} < 9)\" is {2}\n", x, x, !(x > 5 && x < 9)); // returns False because ! (not) is used to reverse the result
		}
	
		public static void ComparisonOperators()
		{
			int x = 1;
			int y = 2;
			Console.WriteLine("Result of \"Equal To\" Operator - Value of \"{0} == {1}\" is {2}\n", x, y, x == y);  // returns "False" because 1 is not equal to 2
			Console.WriteLine("Result of \"Not equal\" Operator - Value of \"{0} != {1}\" is {2}\n", x, y, x != y);  // returns "True" because 1 is not equal to 2
			Console.WriteLine("Result of \"Greater than\" Operator - Value of \"{0} > {1}\" is {2}\n", y, x, y > x); // returns True because 2 is greater than 1
			Console.WriteLine("Result of \"Less than\" Operator - Value of \"{0} < {1}\" is {2}\n", y, x, y < x); // returns False because 1 is not greater than 2
			Console.WriteLine("Result of \"Greater than or equal to\" Operator - Value of \"{0} >= {1}\" is {2}\n", y, x, y >= x); // returns True because 2 is greater, or equal, to 1
			Console.WriteLine("Result of \"Less than or equal to\" Operator - Value of \"{0} <= {1}\" is {2}\n", y, x, y <= x); // returns True because 2 is neither less, or equal, to 1
		}

		public static void BitwiseComplementOperator() 
		{
			/*
				Bitwise complement changes all bits. It turns 0 into 1 and 1 into 0.
				The character "~" denotes the complement operator. 
				It affects every bit in the value you apply it to.
			
				Example: before: 1011
					 Operator `: 0100
			 */

			//You must cast the resultant value of the bitwise operation to the type you wish to work.
			byte y = 1;
			byte result = (byte)~y;
			Console.WriteLine("Complement Operator - Value of \" ~{0}\" is {1}\n", y, result);
		}

		private static void Addition() //If you don't understand 'private', it is coming later
		{
			int x = 7;
			int y = 1;
			Console.WriteLine("Addition Operator - Value of \"7 + 1\" is {0}\n", x + y);
		}

		private static void Subtraction()
		{
			int x = 15;
			int y = 13;
			Console.WriteLine("Subtraction Operator - Value of \"15 - 13\" is {0}\n", x - y);
		}

		private static void Multiplication()
		{
			int x = 8;
			int y = 9;
			Console.WriteLine("Multiplication Operator - Value of \"8 * 9\" is {0}\n", x * y);
		}

		private static void Division()
		{
			int x = 18;
			int y = 2;
			Console.WriteLine("Division Operator - Value of \"67 / 9\" is {0}\n", x / y);
		}

		private static void Modulus() //Returns the division remainder
		{
			int x = 67;
			int y = 9;
			Console.WriteLine("Modulus Operator - Value of \"67 % 9\" is {0}\n", x % y);
		}

		private static void Increment() //Increases the value of a variable by 1
		{
			int x = 8;
			x++;
			Console.WriteLine("Increment Operator- Value of \"8++\" is {0}\n", x);
		}

		private static void Decrement() //Decreases the value of a variable by 1
		{
			int x = 8;
			x--;
			Console.WriteLine("Decrement Operator- Value of \"8--\" is {0}\n", x);
		}
	}
}
