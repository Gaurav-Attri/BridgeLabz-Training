using System;
class NegZeroPosCheck{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int res = CheckNum(num);
		if(res == 0) Console.WriteLine("The number is Zero");
		else if(res == 1) Console.WriteLine("The number is Positive");
		else Console.WriteLine("The number is Negative");
	}

	static int CheckNum(int num){
		if(num == 0) return 0;
		else if(num < 0) return -1;
		else return 1;
	}
}
