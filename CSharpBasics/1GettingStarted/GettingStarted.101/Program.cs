using System; //we can use classes from the System namespace.

namespace GettingStarted.OneZeroOne //used to organize your code, and it is a container for classes and other namespaces
{ //The curly braces {} marks the beginning and the end of a block of code.
	public class Program //class is a container for data and methods, which brings functionality to your program
	{
		//'public' is static modifier
		//'static' is keyword
		//'void' is return type
		//'Main' is method name
		public static void Main(string[] args) //starting point of a program
		{
			Console.WriteLine("###### Welcome to Getting Started C# 101 #####"); //output/print text

			Console.WriteLine("***** Variables in C# *****\n"); //\n print the new line at the end
			Variables.PrintAllTypesOfVariables(); //different type of variables
			Console.WriteLine("***************************\n");

			Console.WriteLine("***** Making comment in C# *****\n");
			CommentInCode.PrintTypesOfCommentsInCode(); //way of making comment in code
			Console.WriteLine("********************************\n");

			Console.WriteLine("***** Type casting in C# *****\n");
			TypeCasting.ImplicitTypeCasting(); //implicit type casting
			TypeCasting.ExplicitTypeCasting(); //explict type casting
			TypeCasting.BuiltInTypeConversionMethods(); //built in methods for type casting
			Console.WriteLine("******************************\n");

			//Console.WriteLine("***** User input in C# *****\n");
			//Uncomment the code below if you want to test 
			//UserInput.ReadInput();
			//Console.WriteLine("****************************\n");

			Console.WriteLine("***** Operators in C# *****\n");
			Operators.CommonOperatos();
			Operators.AssignmentOperators();
			Operators.ComparisonOperators();
			Operators.LogicalOperators();
			Operators.BitwiseComplementOperator();
			Console.WriteLine("****************************\n");

			Console.WriteLine("***** Math class in C# *****\n");
			Maths.MathmaticalTasks();
			Console.WriteLine("****************************\n");

			Console.WriteLine("***** Play with string in C# *****\n");
			Strings.SimpleString();
			Strings.StringMethods();
			Strings.SpecialCharacters();
			Console.WriteLine("**********************************\n");

			Console.WriteLine("***** Booleans in C# *****\n");
			Booleans.Values();
			Booleans.Expression();
			Console.WriteLine("**************************\n");

			Console.WriteLine("***** Conditions in C# *****\n");
			Conditions.Learn();
			Console.WriteLine("****************************\n");
		}
	}

	//If you don't understand 'public' 'static' 'void', no problem it will come later.
}
