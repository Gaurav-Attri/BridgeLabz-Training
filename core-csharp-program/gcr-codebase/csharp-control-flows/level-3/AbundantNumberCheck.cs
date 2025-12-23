using System;
class AbundantNumberCheck{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		// Calculating the sum of all the divisors of num
		int sum = 0;
		for(int i = 1; i < num; i++){
			if(num%i == 0) sum += i;
		}
		// Checking if the number is Abundant Number
		if(sum > num){
			Console.WriteLine("The number " + num + " is an abundant number");
		}
		else{
			Console.WriteLine("The number " + num + " is not an abundant number");
		}
	}
}
