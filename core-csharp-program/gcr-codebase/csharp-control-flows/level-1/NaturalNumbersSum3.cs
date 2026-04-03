using System;
class NaturalNumbersSum3{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int loopSum = 0, formulaSum = (num*(num+1))/2;
		for(int i = 1; i <= num; i++){
			loopSum += i;
		}
		Console.WriteLine("loopSum: " + loopSum);
		Console.WriteLine("formulaSum: " + formulaSum);
	}
}
