using System;
class Factorial2{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int fact = 1;
		for(int i = 1; i <= num; i++){
			fact *= i;
		}
		Console.WriteLine("Factorial is: " + fact);
	}
}
