using System;
class SmallestOfThreeCheck{
	static void Main(string[] args){
		Console.WriteLine("Enter three number, each on a new line: ");
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int num3 = int.Parse(Console.ReadLine());
		Console.WriteLine("Is the first number the the smallest? " + (num1 < num2 && num1 < num3));
	}
}
