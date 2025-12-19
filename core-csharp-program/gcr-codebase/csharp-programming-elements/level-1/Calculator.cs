using System;
class Calculator{
	static void Main(String[] args){
		Console.WriteLine("Please enter the first number");
		float firstNumber = float.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the second number");
		float secondNumber = float.Parse(Console.ReadLine());
		float addition = firstNumber + secondNumber;
		float subtraction = firstNumber - secondNumber;
		float multiplication = firstNumber * secondNumber;
		float division = firstNumber / secondNumber;
		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + firstNumber + " and " + secondNumber + " is " + addition + " " + subtraction + " " + multiplication + " " + division);
	}
}
