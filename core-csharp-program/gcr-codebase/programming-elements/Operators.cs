using System;
class Operators{
	static void Main(String[] args){
		// Arithmetic Operators:
		Console.WriteLine("Arithmetic Operators: ");
		Console.WriteLine("10 + 20 is: " + (10 + 20));
		Console.WriteLine("10 - 20 is: " + (10 - 20));
		Console.WriteLine("10 * 20 is: " + (10 * 20));
		Console.WriteLine("20 / 10 is: " + (20 / 10));
		Console.WriteLine();

		// Relational Operators:
		int relOperand1 = 10;
		int relOperand2 = 20;
		Console.WriteLine("Relational Operators: ");
		Console.WriteLine("relOperand1 == relOperand2 is: " + (relOperand1 == relOperand2));
		Console.WriteLine("relOperand1 != relOperand2 is: " + (relOperand1 != relOperand2));
		Console.WriteLine("relOperand1 >= relOperand2 is: " + (relOperand1 >= relOperand2));
		Console.WriteLine("relOperand1 <= relOperand2 is: " + (relOperand1 <= relOperand2));
		Console.WriteLine("relOperand1 > relOperand2 is: " + (relOperand1 > relOperand2));
		Console.WriteLine("relOperand1 < relOperand2 is: " + (relOperand1 < relOperand2));
		Console.WriteLine();

		// Logical Operators:
		bool logOperand1 = true;
		bool logOperand2 = false;
		Console.WriteLine("Logical Operators:");
		Console.WriteLine("logOperand1 && logOperand2 is: " + (logOperand1 && logOperand2));
		Console.WriteLine("logOperand1 || logOperand2 is: " + (logOperand1 || logOperand2));
		Console.WriteLine("!logOperand1 is: " + (!logOperand1));
		Console.WriteLine();

		// Assignment Operators:
		Console.WriteLine("Assignment Operators: ");
		int assignOperand1 = 10;
		Console.WriteLine("assignOperand1 is: " + assignOperand1);
		assignOperand1 += 10;
		Console.WriteLine("assignOperand1 is: " + assignOperand1);
		assignOperand1 -= 10;
		Console.WriteLine("assignOperand1 is: " + assignOperand1);
		assignOperand1 *= 10;
		Console.WriteLine("assignOperand1 is: " + assignOperand1);
		assignOperand1 /= 10;
		Console.WriteLine("assignOperand1 is: " + assignOperand1);

		// is Operator
		Example obj = new Example();
		Console.WriteLine("obj is Eample: " + (obj is Example));
	}

	class Example{
		int ExampleInteger = 10;
		public Example(){
			Console.WriteLine("Object Created");
			Console.WriteLine();
		}
	}
}

