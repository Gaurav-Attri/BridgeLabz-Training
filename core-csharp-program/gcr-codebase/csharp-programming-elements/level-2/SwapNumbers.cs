using System;
class SwapNumbers{
	static void Main(String[] args){
		Console.WriteLine("Please enter the first number: ");
		int number1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the second number: ");
		int number2 = int.Parse(Console.ReadLine());
		// Swapping the numbers using a third variable called temp
		int temp = number1;
		number1 = number2;
		number2 = temp;
		Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
	}
}
