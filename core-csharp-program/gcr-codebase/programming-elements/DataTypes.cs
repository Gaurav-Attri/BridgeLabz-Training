using System;
class DataTypes{
	static void Main(String[] args){
		// Declaration and Initilialization of variables:
		int integerVar = 10;
		long longVar = 100000000000;
		float floatVar = 10.23f;
		double doubleVar = 10000.32334;
		char charVar = 'c';
		bool boolVar = true;
		string stringVar = "This is a String Variable";

		// Printing the variables on Console
		Console.WriteLine("Value of integerVar is: " + integerVar);
		Console.WriteLine("Value of longVar: " + longVar);
		Console.WriteLine("Value of floatVar: " + floatVar);
		Console.WriteLine("Value of doubleVar: " + doubleVar);
		Console.WriteLine("Value of charVar: " + charVar);
		Console.WriteLine("Value of boolVar: " + boolVar);
		Console.WriteLine("Value of stringVar: " + stringVar);
		Console.WriteLine();


		// Implicit Type Casting:
		integerVar = charVar;
		longVar = integerVar;
		floatVar = longVar;
		doubleVar = floatVar;
		Console.WriteLine("After Implicit Type Casting:");
		Console.WriteLine("Value of integerVar is: " + integerVar);
		Console.WriteLine("Value of longVar is: " + longVar);
		Console.WriteLine("Value of floatVar is: " + floatVar);
		Console.WriteLine("Value of doubleVar is: " + doubleVar);
		Console.WriteLine();


		// Explicit Type Casting:
		charVar = Convert.ToChar(integerVar);
		integerVar = (int)(longVar);
		Console.WriteLine("After Explicit Type Casting");
		Console.WriteLine("Value of integerVar: " + integerVar);
		Console.WriteLine("Value of charVar: " + charVar);


	}
}
