using System;
class NNaturalNumSum{
	static void Main(string[] args){
		Console.WriteLine("Please enter a natural number: ");
		int n = int.Parse(Console.ReadLine());
		if(n <= 0) System.Environment.Exit(1);
		Console.WriteLine("Sum of " + n + " natural numbers using Recursion: " + RecursiveSum(n));
		Console.WriteLine("Sum of " + n + " natural numbers using Formula: " + FormulaSum(n));
	}

	static int RecursiveSum(int n){
		// Base Case
		if(n == 1) return 1;
		return n + RecursiveSum(n-1);
	}

	static int FormulaSum(int n){
		int sum = (n*(n+1))/2;
		return sum;
	}
}
