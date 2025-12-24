using System;
class RemainderAndQuotientFinder{
	static void Main(string[] args){
		Console.WriteLine("Please enter the first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the second number: ");
		int num2 = int.Parse(Console.ReadLine());
		int[] remainderAndQuotient = RemainderAndQuotient(num1, num2);
		Console.WriteLine("Remainder is: " + remainderAndQuotient[0]);
		Console.WriteLine("Quotient is: " + remainderAndQuotient[1]);
	}

	static int[] RemainderAndQuotient(int num1, int num2){
		return new int[] {num1%num2, num1/num2};
	}
}
