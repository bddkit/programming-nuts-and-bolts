using System; //we can use classes from the System namespace.

namespace GettingStarted.OneZeroOne //used to organize your code, and it is a container for classes and other namespaces
{ //The curly braces {} marks the beginning and the end of a block of code.
	public class Program //class is a container for data and methods, which brings functionality to your program
	{
		public static void Main(string[] args) //starting point of a program
		{
			Console.WriteLine("Welcome to Getting Started C# 101!"); //output/print text
			Variables.PrintAllTypesOfVariables(); //different type of variables
			CommentInCode.PrintTypesOfCommentsInCode(); //way of making comment in code
			TypeCasting.ImplicitTypeCasting(); //implicit type casting
			TypeCasting.ExplicitTypeCasting(); //explict type casting
			TypeCasting.BuiltInTypeConversionMethods(); //built in methods for type casting

			//Uncomment the code below if you want to test 
			//UserInput.ReadInput();

			Operators.CommonOperatos();
		}
	}

	//If you don't understand 'public' 'static' 'void', no problem it will come later.
}
