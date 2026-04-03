using System;
class ChocolateDistribution{
	static void Main(string[] args){
		Console.WriteLine("Please enter the number of chocolates: ");
		int numberOfChocolates = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the number of children: ");
		int numberOfChildren = int.Parse(Console.ReadLine());
		int[] perChildAndRemainingChocolates = ChocolatesAndRemainder(numberOfChocolates, numberOfChildren);
		Console.WriteLine("The number of chocolates per child is: " + perChildAndRemainingChocolates[0]);
		Console.WriteLine("The number of remaining chocolates is: " + perChildAndRemainingChocolates[1]);
	}

	static int[] ChocolatesAndRemainder(int numberOfChocolates, int numberOfChildren){
		return new int[] {numberOfChocolates/numberOfChildren, numberOfChocolates%numberOfChildren};
	}
}
