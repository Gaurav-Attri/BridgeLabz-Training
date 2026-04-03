using System;
class IntOperations{
	static void Main(String[] args){
		Console.WriteLine("Please enter the value of a, b and c, each on a new line: ");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		int operation1Result = a + b * c;
		int operation2Result = a * b + c;
		int operation3Result = c + a / b;
		int operation4Result = a % b + c;
		Console.WriteLine("The results of Int Operations are " + operation1Result + ", " + operation2Result + ", " + operation3Result + ", and " + operation4Result);
	}
}
