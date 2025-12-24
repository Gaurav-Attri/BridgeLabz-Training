using System;
class NNaturalNumSum{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine("Sum of natural numbers upto " + number + " is " + Sum(number));
	}

	static int Sum(int number){
		int sum = 0;
		for(int i = 1; i <= number; i++) sum += i;
		return sum;
	}
}
