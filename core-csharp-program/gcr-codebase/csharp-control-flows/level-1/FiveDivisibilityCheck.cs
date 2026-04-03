using System;
class FiveDivisibilityCheck{
	static void Main(String[] args){
		Console.WriteLine("Enter the number: ");
		int num = int.Parse(Console.ReadLine());
		Console.WriteLine("Is the number " + num + " divisible by 5? " + (num%5 == 0));
	}
}
