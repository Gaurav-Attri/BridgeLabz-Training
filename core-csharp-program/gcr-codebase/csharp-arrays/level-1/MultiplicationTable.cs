using System;
class MultiplicationTable{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int number = int.Parse(Console.ReadLine());
		int[] multiTable = new int[11];

		for(int i = 1; i <= 10; i++){
			multiTable[i] = (number*i);
		}

		for(int i = 1; i <= 10; i++){
			Console.WriteLine(number + "*" + i + " = " + multiTable[i]);
		}
	}
}
