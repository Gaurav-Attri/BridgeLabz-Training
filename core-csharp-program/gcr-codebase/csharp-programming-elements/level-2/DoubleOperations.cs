using System;
class DoubleOperations{
	static void Main(String[] args){
		Console.WriteLine("Please enter the value of a, b & c, each on a different line: ");
		double a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		double c = double.Parse(Console.ReadLine());
		double operation1Result = a + b * c;
		double operation2Result = a * b + c;
		double operation3Result = c + a / b;
		double operation4Result = a % b + c;
		Console.WriteLine("The results of Double Operations are " + operation1Result + ", " + operation2Result + ", " + operation3Result + ", and " + operation4Result);
	}
}
