using System;
class Factorial{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int fact = 1;
		while(num != 0){
			fact *= num;
			num--;
		}
		Console.WriteLine("Factorial is: " + fact);
	}
}
