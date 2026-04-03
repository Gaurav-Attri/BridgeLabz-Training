using System;
class PowerCaculator{
	static void Main(string[] args){
		Console.WriteLine("Please enter the number (base): ");
		int baseNumber = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the power (exponent): ");
		int exponent = int.Parse(Console.ReadLine());
		int power = 1;

		for(int i = 0; i < exponent; i++){
			power *= baseNumber;
		}

		Console.WriteLine(baseNumber + " raised to the power " + exponent + " is " + power);
	}
}
