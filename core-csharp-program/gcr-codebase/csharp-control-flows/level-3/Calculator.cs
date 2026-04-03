using System;
class Calculator{
	static void Main(string[] args){
		Console.WriteLine("Please enter the first number: ");
		double operand1 = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the second number: ");
		double operand2 = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the operator (+, -, * or /): ");
		string op = Console.ReadLine();

		switch (op){
			case "+":
				Console.WriteLine(operand1 + operand2);
				break;
			case "-":
				Console.WriteLine(operand1 - operand2);
				break;
			case "*":
				Console.WriteLine(operand1 * operand2);
				break;
			case "/":
				Console.WriteLine(operand1 / operand2);
				break;
			default:
				Console.WriteLine("Invalid Operator");
				break;
		}
	}
}
