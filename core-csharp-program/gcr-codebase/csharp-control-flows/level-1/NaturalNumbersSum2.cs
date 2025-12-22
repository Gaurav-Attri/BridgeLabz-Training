using System;
class NaturalNumbersSum2{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int loopSum = 0, formulaSum = (num*(num+1))/2;
		// Calculating sum of first n natural number using while loop
		int i = 1;
		while(i <= num){
			loopSum += i;
			i++;
		}
		Console.WriteLine("loopSum: " + loopSum);
		Console.WriteLine("formulaSum: " + formulaSum);
	}
}
