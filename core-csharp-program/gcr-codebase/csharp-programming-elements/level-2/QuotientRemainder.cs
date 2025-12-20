using System;
class QuotientRemainder{
	static void Main(String[] args){
		Console.WriteLine("Please enter the first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the second number: ");
		int num2 = int.Parse(Console.ReadLine());
		int quotient = num1/num2;
		int remainder = num1%num2;
		Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + num1 + " and " + num2);
	}
}
